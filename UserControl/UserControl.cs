using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

/// <summary>
/// Large amounts of code in this class was written by Benjamin Cooper for the former Rat Gambling project
/// </summary>
namespace UserControl
{
    public partial class UserControl : Form
    {
        public UserControl()
        {
            InitializeComponent();
            uxStartButton.Enabled = false;
        }

        private string exportPath = ""; // the external location to save data to
        private bool isRunning = false; // indicates if the trials are started or stopped
        public int CurrentPhase { get; set; } // the index of the current phase in the phase queue.

        string[] IPAddresses = { "", "", "", "" };
        int index = 0;

        Socket socket;
        Socket[] sockets =
        {
            new TcpClient().Client,
            new TcpClient().Client,
            new TcpClient().Client,
            new TcpClient().Client,
        };


        private void ChamberSelectChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                index = Convert.ToInt32(((RadioButton)sender).Text) - 1;
                Controls.Find("IPAddressBox", false)[0].Text = IPAddresses[index];
                socket = sockets[index];
            }
        }

        private void IPAddressBox_TextChanged(object sender, EventArgs e)
        {
            IPAddresses[index] = ((TextBox)sender).Text;
        }

        private void SendCmd(string cmd)
        {
            if (socket.Connected)
            {
                // attempt to send
                try
                {
                    SocketAsyncEventArgs sendArgs = new SocketAsyncEventArgs();
                    byte[] buffer = Encoding.ASCII.GetBytes(cmd);
                    sendArgs.SetBuffer(buffer, 0, buffer.Length);
                    sendArgs.Completed += SendCompleted;
                    socket.SendAsync(sendArgs);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else
            {
                // attempt to connect and send
                try
                {
                    IPAddress address = IPAddress.Parse(IPAddresses[index]);
                    socket.Connect(address, 25565);
                    SocketAsyncEventArgs sendArgs = new SocketAsyncEventArgs();
                    byte[] buffer = Encoding.ASCII.GetBytes(cmd);
                    sendArgs.SetBuffer(buffer, 0, buffer.Length);
                    sendArgs.Completed += SendCompleted;
                    socket.SendAsync(sendArgs);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        /// <summary>
        /// Sends a string message to the remote control host
        /// </summary>
        /// <param name="msg"></param>
        private void SendMessage(string msg)
        {
            if (socket.Connected)
            {
                byte[] msgBuff = Encoding.ASCII.GetBytes(msg); // the message to be sent
                byte[] msgLen = BitConverter.GetBytes(msgBuff.Length); // the length of the message
                socket.Send(msgLen);
                socket.Send(msgBuff);
            }
        }

        /// <summary>
        /// Recieves a string message from remote control host
        /// </summary>
        /// <returns></returns>
        private string RecieveMessage()
        {
            if (socket.Connected)
            {
                byte[] lenBuff = new byte[sizeof(int)];
                socket.Receive(lenBuff);
                int len = BitConverter.ToInt32(lenBuff, 0);
                byte[] message = new byte[len];
                socket.Receive(message, len, SocketFlags.None);
                return Encoding.ASCII.GetString(message);
            }
            else
            {
                return "ERROR: SOCKET DISCONNECTED";
            }
        }

        private void SendCompleted(object sender, SocketAsyncEventArgs e) { }

        private void uxStartButton_Click(object sender, EventArgs e)
        {
            switch (isRunning)
            {
                case true:
                    isRunning = false;
                    break;
                case false:
                    isRunning = true;
                    break;
            }
            SendCmd("start_stop!");
        }

    }
}
