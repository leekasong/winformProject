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

namespace ChatServer001
{
    public partial class Form1 : Form
    {
        public NetworkStream m_Stream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        const int PORT = 2017;
        private Thread m_thReader;

        public bool m_bStop = false;

        private TcpListener m_listener;
        private Thread m_thServer;

        public bool m_bConnect = false;
        TcpClient m_Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerStop();
            Disconnect();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Message(string msg)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_All.AppendText(msg + "\r\n");
                txt_All.Focus();
                txt_All.ScrollToCaret();

                txt_All.Focus();
            }));
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            
        }

        public void ServerStart()
        {
            m_listener = new TcpListener(PORT);
            m_listener.Start();
        }
    }
}
