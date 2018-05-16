using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialChat
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private string chat;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM1");
            InicializeSerialPort();
            chat = "";
            pictureBoxFriend.Image = Image.FromFile("user.jpg");
            pictureBoxMe.Image = Image.FromFile("user.jpg");
            Open();
        }

        private void InicializeSerialPort()
        {
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.RtsEnable = true;
            serialPort.DataReceived += serialPort_DataReceived;
        }

        private void Open()
        {
            try
            {
                serialPort.Open();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialp;
            string selectText;

            serialp = (SerialPort)sender;
            selectText = string.Format("He: {0} \r\n", serialp.ReadExisting());
            chat += selectText;
            textBoxView.Text = chat;
            textBoxView.Select(textBoxView.Text.Length - selectText.Length + 1, selectText.Length + 1);
            textBoxView.SelectionAlignment = HorizontalAlignment.Left;
            textBoxView.DeselectAll();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string selectText;

            serialPort.WriteLine(textBoxChat.Text);
            selectText = string.Format("Me: {0} \r\n", textBoxChat.Text);
            chat += selectText;
            textBoxChat.Text = "";
            textBoxView.Text = chat;
            textBoxView.Select(textBoxView.Text.Length - selectText.Length + 1, selectText.Length + 1);
            textBoxView.SelectionAlignment = HorizontalAlignment.Right;
            textBoxView.DeselectAll();
        }
    }
}
