using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using PacketServer_001;

namespace PacketServer_002
{
    class Program
    {
        private NetworkStream m_NetStream;
        private TcpListener m_Listener;

        private byte[] sendBuffer = new Byte[1024 * 4];
        private byte[] readBuffer = new Byte[1024 * 4];
        private bool m_blsClientOn = false;
        private Thread m_Thread;
        public AppDomainInitializer m_InitializeClass;
        public Login m_LoginClass;
        static void Main(string[] args)
        {
        }

        public void RUN()
        {
            this.m
        }
    }
}
