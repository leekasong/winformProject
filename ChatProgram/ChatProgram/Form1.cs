using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace ChatProgram
{
    public partial class Form1 : Form
    {

        private TcpListener server;
        private TcpClient client;
        private NetworkStream ns;
        private StreamReader m_Read;
        private StreamWriter m_Write;

        Thread server_thread;
        Thread receive_thread;

        private bool server_flag = false;
        private bool connect_flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            if(btn_Server.Text == "서버 켜기")
            {
                btn_Server.Text = "서버 끄기";
                btn_Server.ForeColor = Color.Red;
                server_thread = new Thread(new ThreadStart(ServerStart));
                server_thread.Start();
            }
            else
            {
                ServerStop();
                btn_Server.Text = "서버 켜기";
                btn_Server.ForeColor = Color.Black;
        
            }
        }

        public void ServerStart()
        {
            try
            {
                server = new TcpListener(7777);
                server.Start();
                Message("서버를 시작합니다.");
                server_flag = true;
                while(server_flag)
                {
                    Socket h_socket = server.AcceptSocket();
                    if(h_socket.Connected)
                    {
                        Message("클라이언트가 접속했습니다.");
                        ns = new NetworkStream(h_socket);
                        m_Read = new StreamReader(ns);
                        m_Write = new StreamWriter(ns);
                        receive_thread = new Thread(new ThreadStart(Receive));
                        receive_thread.Start();
                 
                    }
                    else
                    {
                        Message("접속하지 못했습니다.");
                        Disconnect();
                    }
                }
            }
            catch
            {
                MessageBox.Show("서버를 시작하지 못했습니다.");
                return;
            }
        }

        public void ServerStop()
        {
            if (server_flag)
            {
                server.Stop();
                Disconnect();
            }
        }
        public void Disconnect()
        {
            if(receive_thread != null) receive_thread.Abort();
            if (server_thread != null)
            {
                server_thread.Abort();
                server_flag = false;
            }
            if (client != null)
            {
                client.Close();
                connect_flag = false;
            }

            if(m_Read != null)
            {
                m_Read.Close();
               
            }
            else if(m_Write != null)
            {
                m_Write.Close();
            }
            else if(ns != null)
            {
                ns.Close();
            }
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
            Disconnect();
        }

        public void Message(string str)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                txt_All.AppendText(str + "\r\n");
            }));
        }

        public void Receive()
        {
            
            try
            {
                string str;
                while ((str = m_Read.ReadLine()) != null)
                {
                    Message("상대편: " + str);
                }

            }
            catch
            {
                Message("받는 과정에서 오류가 발생했습니다.");
            }

            Disconnect();
           
        }

        public void Connect()
        {
            if(txt_ServerIp.Text != "")
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(txt_ServerIp.Text, 7777);
                    connect_flag = true;
                    Message("서버에 연결되었습니다.");
                    ns = client.GetStream();
                    m_Read = new StreamReader(ns);
                    m_Write = new StreamWriter(ns);

                    receive_thread = new Thread(new ThreadStart(Receive));
                    receive_thread.Start();

                }
                catch
                {
                    MessageBox.Show("클라이언트에서 연결을 실패했습니다.");
                    return;
                }
               
            }
            else
            {
                MessageBox.Show("IP를 넣어주세요.");
                return;
            }
           
        }

        public void send()
        {
            try
            {
                m_Write.WriteLine(txt_Send.Text);
                m_Write.Flush();
                Message("나: " + txt_Send.Text);
            }
            catch
            {
                Message("데이터를 보내지 못했습니다.");
            }
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
            if (btn_Connect.Text == "서버 연결")
            {
                btn_Connect.Text = "연결 끊기";
                btn_Connect.ForeColor = Color.Red;
       
            }
            else
            {
                btn_Connect.Text = "서버 연결";
                btn_Connect.ForeColor = Color.Black;
                Disconnect();
            }
           
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            send();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
