using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Shell32;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using musicPacket;

namespace MusicServer
{
    public partial class Form1 : Form
    {
        private int PORT = 25000;
        private NetworkStream netStream;
        private NetworkStream requestStream;

        private TcpListener server;
        private Thread sendThread;
        private Thread receiveThread;

        private byte[] initBuffer = new byte[1024 * 4];
        private byte[] requestBuffer = new byte[1024 * 4];
        private byte[] dataBuffer = new byte[1024 * 4];

        private bool m_server_flag = false;
        private bool m_Request = false;
        private FileStream fs;
        private Folder folder;

        private string[] MP3_files;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //자신의 ip 주소를 알아낸다.
            IPHostEntry host = Dns.GetHostByName(Dns.GetHostName());
            string myip = host.AddressList[0].ToString();
            txtIp.Text = myip;
            txtPort.Text = "" + PORT;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(txtPath.Text.CompareTo("") == 0)
            {
                MessageBox.Show("전송 가능한 mp3 파일이 없습니다. 경로를 다시 지정하십시오.");
                return;
            }

            try
            {
                
               if(!m_server_flag)
                { 
                    server = new TcpListener(PORT);
                    server.Start();
                    btnStart.Text = "Stop";

                    LogMessage("server start!");
                    LogMessage(txtPath.Text);
                    LogMessage("waiting for client access");
                    Socket h_client = server.AcceptSocket();
                
                    if (h_client.Connected)
                    {
                        netStream = new NetworkStream(h_client);
                    
                        LogMessage("클라이언트 접속!");
                        InitSend();
                        receiveThread = new Thread(new ThreadStart(RequestHandler));
                        receiveThread.Start();

                        m_Request = true;
                  
                    }
                    m_server_flag = true;

                }
                else
                {
                    btnStart.Text = "Start";
                    receiveThread.Abort();
                    netStream.Close();
                    server.Stop();
                    m_server_flag = false;
                }

            }
            catch
            {
                MessageBox.Show("서버를 시작하지 못했습니다.");
            }
            

        }


        private void RequestHandler()
        {

           while(m_Request)
            {
                netStream.Read(this.requestBuffer, 0, this.requestBuffer.Length);
                RequestPacket m_requestPacket = (RequestPacket)Packet.Deserialize(requestBuffer);
                string m_ItemName = m_requestPacket.ItemName;
                LogMessage("download request accepted!");
                //해당 파일 보낸다. 
              
                sendThread = new Thread(delegate ()
                {
                    MP3Send(m_ItemName);
                });
                sendThread.Start();
            }  
        }

        private Shell32.Folder GetShell32NameSpace(Object folder)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }


        private void MP3Send(string parm_ItemName)
        {
         

            
            MusicDataPacket p_music_data = new MusicDataPacket();
            byte[] m_ans = new byte[1024];

            //경로 : txtPath 참고 , 파일이름으로 찾는다.
            ShellClass shell = new ShellClass();
            this.folder = GetShell32NameSpace(txtPath.Text);
            string requestPath = "";
            foreach (string s in MP3_files)
            {
                string Fname = Path.GetFileName(s);
                FolderItem mp3File = folder.ParseName(Fname);
                if(parm_ItemName == folder.GetDetailsOf(mp3File, 21))
                {
                    //찾았다. 파일 타이틀이 아니라 파일의 이름을 가져온다.
                    requestPath = s;
                    break;
                }
            }

            fs = new FileStream(requestPath, FileMode.Open, FileAccess.Read);
            FileInfo fi = new FileInfo(fs.Name);
            long LengthQ = fi.Length / 1024;
            long LengthR = fi.Length % 1024;
            long n = 0;
            for(n=0; n < LengthQ; n++)
            {
                fs.Seek(1024 * n, SeekOrigin.Begin);
                fs.Read(m_ans, 0, m_ans.Length);
                p_music_data.Type = (int)PacketType.데이터;
                p_music_data.Length = m_ans.Length;
                p_music_data.MP3_Data = m_ans;
                Packet.Serialize(p_music_data).CopyTo(this.dataBuffer, 0);
                SendData(dataBuffer);
            }
            if((int)LengthR != 0)
            {
                fs.Seek(1024 * n, SeekOrigin.Begin);
                fs.Read(m_ans, 0, 1024);
                p_music_data.Type = (int)PacketType.데이터;
                p_music_data.Length = m_ans.Length;
                p_music_data.MP3_Data = m_ans;
                Packet.Serialize(p_music_data).CopyTo(this.dataBuffer, 0);
                SendData(dataBuffer);
            }

            p_music_data.Type = (int)PacketType.데이터;
            p_music_data.Length = -1;
            Packet.Serialize(p_music_data).CopyTo(this.dataBuffer, 0);
            SendData(dataBuffer);
            LogMessage(fi.FullName);
           
            fs.Close();
         
               


        }

        private void InitSend()
        {
            Invoke(new MethodInvoker(delegate ()
            {
                int size = lstMusic.Items.Count;
                string[,] items = new string[size, 4];
                for (int i = 0; i < size; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        items[i, j] = lstMusic.Items[i].SubItems[j].Text;
                    }
                    
                }

                InitPacket p_init = new InitPacket();
                p_init.Type = (int)PacketType.초기화;
                p_init.Data = items;
                p_init.Length = size;
                Packet.Serialize(p_init).CopyTo(this.initBuffer, 0);
                SendData(initBuffer);
            }));
        }

        private void SendData(byte[] a_data)
        {
            this.netStream.Write(a_data, 0, a_data.Length);
            this.netStream.Flush();
            for (int i = 0; i < 1024 * 4; i++)
                a_data[i] = 0;
        }

        private void LogMessage(string msg)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                txtLog.AppendText(msg + "\r\n");
                txtLog.Focus();
                txtLog.ScrollToCaret();
            }));
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            //폴더브라우저 다이얼로그로 path를 설정한다.
            if(fbdPath.ShowDialog() == DialogResult.OK)
            {
                //리스트뷰에 아이템이 이미 존재한다면 없앤다.
                if(lstMusic.Items.Count != 0)
                {
                    ClearMusicList();
                    ClearMP3Files();
                }

                
                ListViewItem item;
                string[] itemStr = new string[4];
                string path = fbdPath.SelectedPath;
                txtPath.Text = fbdPath.SelectedPath;

                ShellClass shell = new ShellClass();
                this.folder = shell.NameSpace(path);
         

                MP3_files = Directory.GetFiles(path);
                string Fname;
                foreach(string s in MP3_files)
                {
                    Fname = Path.GetFileName(s);
                    FolderItem mp3File = folder.ParseName(Fname);
                    string type = folder.GetDetailsOf(mp3File, 2);
                    if (type.CompareTo("MP3 파일") != 0) continue;
                    itemStr.SetValue(folder.GetDetailsOf(mp3File, 21), 0);
                    itemStr.SetValue(folder.GetDetailsOf(mp3File, 13), 1);
                    itemStr.SetValue(folder.GetDetailsOf(mp3File, 27), 2);
                    itemStr.SetValue(folder.GetDetailsOf(mp3File, 28), 3);

                    item = new ListViewItem(itemStr);
                    lstMusic.Items.Add(item);
                }

            }
        }

        private void ClearMP3Files()
        {
            int size = MP3_files.Length;
            for (int i = 0; i < size; i++)
            {
                MP3_files[i] = "";
            }
        }

        private void ClearMusicList()
        {
            Invoke(new MethodInvoker(delegate()
            {
                //size로 카운트를 받아서 없앤다.
                int size = lstMusic.Items.Count;
                for(int i = 0; i < size; i++)
                {
                    lstMusic.Items.RemoveAt(0);
                }
                    
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sendThread != null)
                sendThread.Abort();
            if (receiveThread != null)
                receiveThread.Abort();
            if(sendThread != null)
                sendThread.Abort();
        }
    }
}
