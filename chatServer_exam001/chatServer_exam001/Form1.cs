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
using System.Threading;
using System.IO;

namespace chatServer_exam001
{
    public partial class Form1 : Form
    {
        public NetworkStream m_Stream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        const int PORT = 2002;
        private Thread m_thReader;

        public bool m_bStop = false;

        private TcpListener m_listener;
        private Thread m_thServer;

        public bool m_bConnect = false;
        TcpClient m_client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
            Disconnect();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_all.AppendText(msg + "\n");
                txt_all.Focus();
                txt_all.ScrollToCaret();
                ChatText.Focus();
            }));
        }

        public void ServerStart()
        {
            try
            {
                m_listener = new TcpListener(PORT);
                m_listener.Start();

                m_bStop = true;
                Message("클라이언트 접속을 대기중!");

                while(m_bStop)
                {
                    Socket hClient = m_listener.AcceptSocket();

                    if(hClient.Connected)
                    {
                        m_bConnect = true;
                        Message("클라이언트가 접속했음.");

                        m_Stream = new NetworkStream(hClient);
                        m_Read = new StreamReader(m_Stream);
                        m_Write = new StreamWriter(m_Stream);

                        m_thReader = new Thread(new ThreadStart(Receive));
                        m_thReader.Start();
                    }
                }
            }
            catch
            {
                Message("시작 도중에 오류가 발생!");
                return;
            }
        }

        public void ServerStop()
        {
            if(!m_bStop)
            {
                return;
            }

            m_listener.Stop();

            m_Read.Close();
            m_Write.Close();

            m_Stream.Close();

            m_thReader.Abort();
            m_thServer.Abort();

            Message("서비스가 종료되었습니다.");
        }

        public void Connect()
        {
            m_client = new TcpClient();

            try
            {
                m_client.Connect(txt_ServerIp.Text, PORT);
            }
            catch
            {
                m_bConnect = false;
                return;
            }

            m_bConnect = true;
            Message("서버에 연결되었습니다.");

            m_Stream = m_client.GetStream();
            m_Read = new StreamReader(m_Stream);
            m_Write = new StreamWriter(m_Stream);

            m_thReader = new Thread(new ThreadStart(Receive));
            m_thReader.Start();
        }

        public void Disconnect()
        {
            if (!m_bConnect)
                return;

            m_bConnect = false;

            m_Read.Close();
            m_Write.Close();

            m_Stream.Close();
            m_thReader.Abort();

            Message("상대편과 연결이 중단됨!");
        }

        public void Receive()
        {
            try
            {
                while(m_bConnect)
                {
                    string szMessage = m_Read.ReadLine();
                    if (szMessage != null) Message("상대편 >>>> : " + szMessage);
                }
            }
            catch
            {
                Message("데이터를 읽는 과정에서 오류가 발생하였습니다.");
            }

            Disconnect();
        }

        void Send()
        {
            try
            {
                m_Write.WriteLine(ChatText.Text);
                m_Write.Flush();
                Message(">>> : " + ChatText.Text);
                ChatText.Text = "";
            }
            catch
            {
                Message("데이터 보내기 실패!");
            }
        }

        private void ServerStop_btn_Click(object sender, EventArgs e)
        {
            if(ServerStop_btn.Text == "서버 켜기")
            {
                m_thServer = new Thread(new ThreadStart(ServerStart));
                m_thServer.Start();

                ServerStop_btn.Text = "서버 멈춤";
                ServerStop_btn.ForeColor = Color.Red;
            }
            else
            {
                ServerStop();
                ServerStop_btn.Text = "서버 켜기";
                ServerStop_btn.ForeColor = Color.Black;
            }
        }

        private void ServerConnect_Btn_Click(object sender, EventArgs e)
        {
            if(ServerConnect_Btn.Text == "서버 연결")
            {
                Connect();
                if(m_bConnect)
                {
                    ServerConnect_Btn.Text = "연결 끊기";
                    ServerConnect_Btn.ForeColor = Color.Red;
                }
                else
                {
                    Disconnect();
                    ServerConnect_Btn.Text = "서버 연결";
                    ServerConnect_Btn.ForeColor = Color.Black;
                }
            }
        }

        private void Send_Btn_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void ChatText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send();
        }
    }
}
