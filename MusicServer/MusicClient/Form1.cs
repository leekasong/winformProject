using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using musicPacket;
using System.Threading;
using Shell32;
using WMPLib;

namespace MusicClient
{
    public partial class Form1 : Form
    {
        public NetworkStream nStream;
        private BinaryWriter requestWriter;
        private BinaryReader dataReader;
        public TcpClient client;
        private int PORT = 25000;
        private bool m_blsConnect = false;
        private bool m_client_flag = false;
        private bool m_file = false;
        private bool m_play_flag = false;
        private bool m_shuffle = false;
        private DialogResult dr;
     
        private Thread receiveHandler;
        private InitPacket initPacket;
        private MusicDataPacket dataPacket;
        private RequestPacket requestPacket;
        private int readsize = 0;
        private int current_index = -1;
        private int old_index = -1;

        private byte[] readBuffer = new byte[1024 * 4];
        private byte[] sendBuffer = new byte[1024 * 4];

        private WindowsMediaPlayer m_wmp;
        IWMPMedia m_Media;
        IWMPPlaylist PlayList;
       
        private string[] playArr;
        private int playArrIndex = 0;
        private const int playArrSize = 100;




        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtIp.Text.CompareTo("") == 0 || txtPort.Text.CompareTo("") == 0)
            {
                MessageBox.Show("IP나 포트번호를 적어주세요.");
                return;
            }
            client = new TcpClient();
            if (!m_client_flag)
            {
                try
                {
                    client.Connect(this.txtIp.Text, PORT);
                    nStream = this.client.GetStream();
                    requestWriter = new BinaryWriter(nStream);
                    dataReader = new BinaryReader(nStream);
                    btnConnect.ForeColor = Color.Red;
                    btnConnect.Text = "Disconnect";

                }
                catch
                {
                    MessageBox.Show("접속 에러");
                    btnConnect.Text = "Connect";
                    btnConnect.ForeColor = Color.Black;
                    return;
                }
                m_client_flag = true;
            }
            else
            {
                btnConnect.Text = "Connect";
                btnConnect.ForeColor = Color.Black;

                receiveHandler.Abort();
                dataReader.Close();
                requestWriter.Close();
                nStream.Close();
                client.Close();
            }
            m_blsConnect = true;
            receiveHandler = new Thread(new ThreadStart(ReceiveHandler));
            receiveHandler.Start();


        }

        private void ReceiveHandler()
        {
          
            while (m_blsConnect)
            {
                while(-1 != dataReader.Read(this.readBuffer, 0, this.readBuffer.Length))
                    ReceiveInit();
            }
        }

        

        public void ReceiveInit()
        {
            Invoke(new MethodInvoker(delegate ()
            {


                Packet packet = (Packet)Packet.Deserialize(this.readBuffer);
                switch ((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        {

                            initPacket = (InitPacket)InitPacket.Deserialize(this.readBuffer);


                            ListViewItem item;
                            string[,] files = initPacket.Data;
                            string[] itemStr = new string[4];
                            int size = initPacket.Length;
                            for (int i = 0; i < size; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    itemStr.SetValue(files[i, j], j);
                                }
                                item = new ListViewItem(itemStr);
                                lstMusic.Items.Add(item);
                            }

                            break;
                        }
                    case (int)PacketType.데이터:
                        {
                            
                            dataPacket = (MusicDataPacket)Packet.Deserialize(this.readBuffer);
                            int p_length = dataPacket.Length;
                          

                            FileStream fs;
                            if (p_length > 0)
                            {
                                readsize += p_length;
                                
                                if (!m_file)
                                {
                                    fs = new FileStream(txtPath.Text + "\\" + requestPacket.ItemName+".mp3", FileMode.Create);
                                    m_file = true;
                                }
                                else
                                {
                                    fs = new FileStream(txtPath.Text + "\\" + requestPacket.ItemName+".mp3", FileMode.Append, FileAccess.Write);
                                }
                      

                                    fs.Write(dataPacket.MP3_Data, 0, 1024);
                                    if((int)(readsize * 100 / 5000) <= 100)
                                        pgDownload.Value = (int)(readsize * 100 / 5000);

                                    fs.Close();
                            }
                            else
                            {
                                pgDownload.Value = 100;
                                MessageBox.Show("다운로드가 완료되었습니다.");
                                m_file = false;
                                PrintDownload();
                                
                            }
                            
                           
                            break;
                        }

                }






            }));
           
        }

        private void PrintDownload()
        {
            Invoke(new MethodInvoker(delegate ()
            {
                ListViewItem item;
                string[] itemStr = new string[4];
                string path = txtPath.Text;
                

                ShellClass shell = new ShellClass();
                Folder folder = shell.NameSpace(path);
                //다 가져오는게 아니고 선택된 파일만 가져온다

                string[] MP3_files = Directory.GetFiles(path);
                string Fname = "";
                foreach (string s in MP3_files)
                {
                    if (s.CompareTo(txtPath.Text + "\\" + requestPacket.ItemName + ".mp3") == 0)
                    {
                        Fname = Path.GetFileName(s);
                        break;
                    }          
                }
                if(Fname.CompareTo("") == 0)
                {
                    MessageBox.Show("리스트뷰 출력시 오류 발생! 파일을 삭제하고 다시 다운로드하여 주십시오");
                    return;
                }
                FolderItem mp3File = folder.ParseName(Fname);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 21), 0);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 13), 1);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 27), 2);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 28), 3);

                item = new ListViewItem(itemStr);
                lstPlay.Items.Add(item);
                int focusedIndex = lstPlay.Items.IndexOf(item);
                lstPlay.Items[focusedIndex].Focused = true;
                m_Media = m_wmp.newMedia(txtPath.Text + "\\" + lstPlay.FocusedItem.Text + ".mp3");

                bool exist = false;
                for (int i = 0; i <= playArrIndex; i++)
                {
                    if (playArr[i] == m_Media.getItemInfo("Name"))
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    PlayList.appendItem(m_Media);
                    playArr[playArrIndex++] = m_Media.getItemInfo("Name");
                    m_wmp.currentPlaylist = PlayList;
                    
                    old_index = 0;
                }
            }));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtPort.Text = "" + PORT;
            m_wmp = new WindowsMediaPlayer(); 
            m_wmp.settings.autoStart = false;
            PlayList = m_wmp.newPlaylist("MusicPlayer", "");

            playArr = new string[playArrSize];
            tbPlay.Value = 0;
            

        }
        private void wplayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {

                m_wmp.controls.play();
                m_wmp.controls.previous();
          
                Invoke(new MethodInvoker(delegate () 
                {
                    lblPlay.Text = m_wmp.currentPlaylist.Item[current_index].name;
                    tbPlay.Value = tbPlay.Minimum;
                }));
                m_wmp.controls.currentPosition = 0;
                PlayTimer.Start();
            }
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            if((dr = fbdSave.ShowDialog()) == DialogResult.OK)
            {

                txtPath.Text = fbdSave.SelectedPath;
                pgDownload.Value = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dr != DialogResult.OK)
            {
                MessageBox.Show("저장 경로를 설정하지 않았습니다.");
                return;
            }
            if(lstMusic.FocusedItem == null)
            {
                MessageBox.Show("파일을 선택하세요");
                return;
            }
            readsize = 0;
            pgDownload.Value = 0;
            string ItemName = lstMusic.FocusedItem.SubItems[0].Text;
            requestPacket = new RequestPacket();
            requestPacket.Type = (int)PacketType.리퀘스트;
            requestPacket.ItemName = ItemName;

            Packet.Serialize(requestPacket).CopyTo(this.sendBuffer, 0);

            requestWriter.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            requestWriter.Flush();

            ClearSendBuffer();
          
           
          
        }

        private void ClearSendBuffer()
        {
            for (int i = 0; i < 1024 * 4; i++)
                sendBuffer[i] = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (receiveHandler != null)
                receiveHandler.Abort();
            if(m_wmp != null)
            {
                m_wmp.controls.stop();
                m_wmp.close();
            }
            readBuffer = null;
            sendBuffer = null;
            playArr = null;
            dataReader = null;
            requestWriter = null;
            nStream = null;
            if(client != null)
                client.Close();

        }
     

        private void PlayRewind(int NewState)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
                {


                    //lblplay를 바꾸낟.
                    //stop 후 처음부터 시작 한다.
                    //current_index, old_index도 초기화한다.
                    if (current_index + 1 == playArrIndex)
                    {        
                        m_wmp.controls.stop();
                        PlayTimer.Stop();
                        tbPlay.Maximum = (int)(m_Media.duration * 1000);
                        m_wmp.controls.play();
                        old_index = current_index = 0;
                        tbPlay.Value = 0;
                        PlayTimer.Start();
                        lblPlay.Text = playArr[current_index];
                    }
                    else
                    {
                        tbPlay.Value = 0;
                        PlayTimer.Start();
                        old_index = current_index += 1;
                        lblPlay.Text = playArr[current_index];
                    }
                }
                
            }));
        }
      
        private void PlayNormal(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
               
                if (current_index == playArrIndex)
                {
                    m_wmp.controls.stop();
                    PlayTimer.Stop();
                }
                else
                {
                    
                    tbPlay.Value = 0;
                    PlayTimer.Start();
                    old_index = current_index += 1;
                    lblPlay.Text = playArr[current_index];
                }
            }
        }

        private void PlayShuffle(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsTransitioning)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    
                    lblPlay.Text = m_wmp.currentMedia.name;
                    for(int i = 0; i <= playArrIndex; i++)
                    {
                        if(playArr[i].CompareTo(lblPlay.Text) == 0)
                        {
                            old_index = current_index = i;
                            return;
                        }
                    }
                    
                }));
            }
        }
     
        private void CalculatePlayIndex()
        {
            if (m_wmp.currentPlaylist.count > 1)
            {

                if (old_index < current_index)
                {
                    for (int i = old_index; i < current_index; i++)
                    {
                        m_wmp.controls.next();

                    }

                }
                else
                {
                    for (int i = old_index; i > current_index; i--)
                    {
                        m_wmp.controls.previous();
                    }
                }


            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(lstPlay.FocusedItem == null)
            {
                MessageBox.Show("재생할 파일을 선택하세요");
                return;
            }
            if(cbPlayMode.Text.CompareTo("") == 0)
            {
                MessageBox.Show("재생 모드를 선택하세요");
                return;
            }
           
            if (!m_play_flag)
            {
                btnPlay.Image = Properties.Resources.Pause;
                current_index = lstPlay.FocusedItem.Index;
                m_wmp.controls.play();

               
                    CalculatePlayIndex();

                old_index = current_index;
                tbPlay.Maximum = (int)(m_Media.duration * 1000);
                PlayTimer.Start();
                if(!m_shuffle)
                    lblPlay.Text = lstPlay.FocusedItem.Text;
                m_play_flag = true;
            }
            else
            {
                
                btnPlay.Image = Properties.Resources.Play;
                if (old_index == current_index)
                    m_wmp.controls.pause();
                else
                    m_wmp.controls.stop();
                PlayTimer.Stop();
                m_play_flag = false;
            }
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            
            ListViewItem item = lstPlay.FocusedItem;
            if(item.Index == current_index && m_play_flag == true)
            {
                MessageBox.Show("현재 재생중인 곡은 삭제할 수 없습니다.");
                return;
            }
            item.Remove();
        }

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            if (tbPlay.Value < tbPlay.Maximum)
            {
                if (m_wmp.controls.currentPosition * 1000 > m_Media.duration * 1000) return;
                tbPlay.Value = (int)(m_wmp.controls.currentPosition * 1000);
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(current_index == 0)
            {
                MessageBox.Show("리스트의 처음곡입니다.");
                return;
            }
            if (m_wmp.settings.getMode("loop")) return;
            if (m_wmp.settings.getMode("shuffle"))
            {
                return;
            }
            m_wmp.controls.previous();
            current_index -= 1;
            lblPlay.Text = lstPlay.Items[current_index].Text;
            old_index = current_index;
            
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            if(current_index == lstPlay.Items.Count - 1)
            {
                MessageBox.Show("리스트의 마지막 곡입니다.");
                return;
            }
            if (m_wmp.settings.getMode("loop")) return;
            if (m_wmp.settings.getMode("shuffle"))
            {
                return;
            }
            m_wmp.controls.next();
            current_index += 1;
            lblPlay.Text = lstPlay.Items[current_index].Text;
            old_index = current_index;
            
        }

        

        enum PlayMode { 한곡반복재생 = 1, 전체반복재생, 전체한번재생, 전체랜덤재생 }
        private void cbPlayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cbPlayMode.SelectedIndex)
            {
                case (int)PlayMode.한곡반복재생:
                    {
                        ClearPlaySettings();
                        m_wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
  
                        break;
                    }
                case (int)PlayMode.전체반복재생:
                    {
                        ClearPlaySettings();
                        m_wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayRewind);
                        m_wmp.settings.setMode("전체반복", true);
                        break;
                    }
                case (int)PlayMode.전체한번재생:
                    {
                        
                        ClearPlaySettings();
                        m_wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayNormal);
          
                        
                        break;
                    }
                case (int)PlayMode.전체랜덤재생:
                    {
                        ClearPlaySettings();

                        m_wmp.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayShuffle);
                        m_shuffle = true;
                        m_wmp.settings.setMode("shuffle", true);
                       
                        
                        break;
                    }
                default:
                    {
                        //기본
                        ClearPlaySettings();
                        break;
                    }
            }

        
        }

        private void ClearPlaySettings()
        {
            m_wmp.PlayStateChange -= new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
            m_wmp.PlayStateChange -= new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayRewind);
            m_wmp.PlayStateChange -= new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayShuffle);
            m_wmp.PlayStateChange -= new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayNormal);
            m_wmp.settings.setMode("loop", false);
            m_wmp.settings.setMode("shuffle", false);
            m_wmp.currentPlaylist = PlayList;
            m_shuffle = false;
            old_index = current_index = 0;
           

        }

        private void tbPlay_Scroll(object sender, EventArgs e)
        {
        
            m_wmp.controls.currentPosition = (tbPlay.Value / (double)tbPlay.Maximum) * m_Media.duration;
             
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                ListViewItem item;
                string[] itemStr = new string[4];
                string path = Path.GetDirectoryName(openFileDialog1.FileName);


                ShellClass shell = new ShellClass();
                Folder folder = GetShell32NameSpace(path);
                //다 가져오는게 아니고 선택된 파일만 가져온다

                string Fname = Path.GetFileName(openFileDialog1.FileName);
                FolderItem mp3File = folder.ParseName(Fname);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 21), 0);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 13), 1);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 27), 2);
                itemStr.SetValue(folder.GetDetailsOf(mp3File, 28), 3);

                item = new ListViewItem(itemStr);
                lstPlay.Items.Add(item);
                int focusedIndex = lstPlay.Items.IndexOf(item);
                lstPlay.Items[focusedIndex].Focused = true;
                m_Media = m_wmp.newMedia(openFileDialog1.FileName);

                bool exist = false;
                for (int i = 0; i <= playArrIndex; i++)
                {
                    if (playArr[i] == m_Media.getItemInfo("Name"))
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    PlayList.appendItem(m_Media);
                    playArr[playArrIndex++] = m_Media.getItemInfo("Name");
                    m_wmp.currentPlaylist = PlayList;

                    old_index = 0;
                }
            }
        }

        private Shell32.Folder GetShell32NameSpace(Object folder)
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");
            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace", System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }
    }
}
