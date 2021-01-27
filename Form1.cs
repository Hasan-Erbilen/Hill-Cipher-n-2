using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        String finalcipherResult = "";
        String finalPlainResult = "";
        UDPSocket server;
        UDPSocket client;
        int comm_port = 19191;

        HillCipher cipher = new HillCipher();
    
        public Form1()
        {
            server = new UDPSocket(this);
            client = new UDPSocket(this);
            server.Server("0.0.0.0", comm_port);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_decrypt.Visible = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            /*create client udp socket with given IP
             * and send the encrypted text to the destination
             */
            client.Client(dst_ip.Text, comm_port);
            client.Send(key_edit.Text + "@" + finalcipherResult);
        }

        private void btn_encrypt_click(object sender, EventArgs e)
        {
            cipher.setKey(key_edit.Text);
            finalcipherResult = cipher.encryptText(senderMessage.Text);
            cipherTextLabel.Text = finalcipherResult;

            btn_decrypt.Visible = true;
            finalPlainResult = "";
        }

        public void setReceivedText(string rcv_text)
        {
            // when recevied the encrypted msg from the network
            //decrypt it

            String[] str_list = rcv_text.Split('@');
            key_edit.Text = str_list[0];

            finalcipherResult = str_list[1];
            cipherTextLabel.Text = str_list[1];
            btn_decrypt.Visible = true;
        }

        private void btn_decrypt_click(object sender, EventArgs e)
        {
            cipher.setKey(key_edit.Text);
            finalPlainResult = cipher.decryptText(finalcipherResult);
            messageReceived.Text = finalPlainResult;
        }
    }
}
