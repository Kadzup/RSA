using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        private RSAWorker worker;
        public Form1()
        {
            InitializeComponent();

            worker = new RSAWorker();
        }

        private void generateKeys_Click(object sender, EventArgs e)
        {
            worker.CreateKeys();

            publicKeyEdit.Text = worker.pubKey;
            privateKeyEdit.Text = worker.privKey;

            label1.Text = $"Публічний ключ (довжина {publicKeyEdit.Text.Length})";
            label2.Text = $"Приватний ключ (довжина {privateKeyEdit.Text.Length})";

            UpdateAll();
        }

        private void encode_Click(object sender, EventArgs e)
        {
            string text = inputText.Text;
            
            try
            {
                string encoded = worker.Encrypt(text);
                outputText.Text = encoded;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Виникла помилка");
            }

            UpdateAll();
        }

        private void decode_Click(object sender, EventArgs e)
        {
            string text = inputText.Text; 
            
            try
            {
                string decoded = worker.Decrypt(text);
                outputText.Text = decoded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Виникла помилка");
            }

            UpdateAll();
        }

        private void updateKeys_Click(object sender, EventArgs e)
        {
            worker.privKey = privateKeyEdit.Text;
            worker.pubKey = publicKeyEdit.Text;

            UpdateAll();
        }

        private bool EnableButtons()
        {
            return inputText.Text.Length > 0 && publicKeyEdit.Text.Length > 0 && privateKeyEdit.Text.Length > 0;
        }

        private void UpdateAll()
        {
            if (EnableButtons())
            {
                encode.Enabled = true;
                decode.Enabled = true;
            }
            else
            {
                encode.Enabled = false;
                decode.Enabled = false;
            }
        }

        private void publicKeyEdit_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void privateKeyEdit_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Kadzup/RSA");
        }
    }
}
