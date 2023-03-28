using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUDP
{
    public partial class Form2 : Form
    {
        string _localPort = "10";
        string _remotePort = "1000";
        UdpClient _applications = new UdpClient();
        Thread _thread;
        bool _exit = false;
        delegate void ClearCacheReceivedData(string Data, string RemoteHost);
        public Form2()
        {
            InitializeComponent();
        }

        private void ReceivedData(string Data, string RemoteHost)
        {
            if (lstReceived.InvokeRequired)
            {
                ClearCacheReceivedData clearCacheReceivedData = new ClearCacheReceivedData(ReceivedData);
                lstReceived.Invoke(clearCacheReceivedData, new object[] { Data, RemoteHost });
                return;
            }
            string msg = "";
            msg = "(Sender: " + RemoteHost + ")" + Data;
            lstReceived.Items.Insert(0, msg);
        }

        private void Explore()
        {
            IPAddress ip;
            byte[] msg;
            string str = "";
            string name = Dns.GetHostName();
            ip = Dns.GetHostEntry(name).AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, Convert.ToInt16(_remotePort));
            while (_exit == false)
            {
                Application.DoEvents();
                if (_applications.Available > 0)
                {
                    msg = _applications.Receive(ref ep);
                    str = System.Text.Encoding.UTF8.GetString(msg);
                    ReceivedData(str, ep.Address.ToString());
                }
            }
        }

        private void bt_Ketnoi_Click(object sender, EventArgs e)
        {
            _localPort = this.tb_LocalPort.Text;
            _remotePort = this.tb_Port.Text;
            _applications = new UdpClient(int.Parse(_localPort));
            _thread = new Thread(Explore);
            _thread.Start();
            this.bt_Ketnoi.Enabled = false;
            tb_IpAddress.ReadOnly = tb_LocalPort.ReadOnly = tb_Port.ReadOnly = true;
        }
    }
}
