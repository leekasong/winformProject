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
using socketProtocol_Library2;

namespace PacketServer001
{
    public partial class Form1 : Form
    {
        private NetworkStream m_NetStream;
        private TcpListener m_Listener;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_blsClinetOn = false;

        private Thread m_Thread;

        public Initialize m_InitializeClass;
        public Login m_LoginClass;

 
        public Form1()
        {
            InitializeComponent();
        }
        public void RUN()
        {
            this.m_Listener = new TcpListener(7777);
            this.m_Listener.Start();

            if (!this.m_blsClinetOn)
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    this.textBox1.AppendText("클라이언트 접속 대기중!\n");
                }));
            }

            Socket Client = this.m_Listener.AcceptSocket();

            if(Client.Connected)
            {
                this.m_blsClinetOn = true;
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.textBox1.AppendText("클라이언트 접속\n");
                }));

                this.m_NetStream = new NetworkStream(Client);
            }

            int nRead = 0;

            while(this.m_blsClinetOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.m_NetStream.Read(this.readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_blsClinetOn = false;
                    this.m_NetStream = null;
                }

                Packet packet = (Packet)Packet.Deserialize(this.readBuffer);

                switch((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        {
                            this.m_InitializeClass = (Initialize)Packet.Deserialize(this.readBuffer);
                            this.textBox1.AppendText("패킷전송성공! Initialize Class Data is " + this.m_InitializeClass);
                            break;
                        }
                    case (int)PacketType.로그인:
                        {
                            this.m_LoginClass = (Login)Packet.Deserialize(this.readBuffer);
                            this.textBox1.AppendText("패킷 전송 성공. Login Class Data is " + this.m_LoginClass);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_Thread = new Thread(new ThreadStart(RUN));
            this.m_Thread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_Listener.Stop();
            this.m_NetStream.Close();
            this.m_Thread.Abort();
        }
    }
}
