using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mesajbaxiletişim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba", "Bilgi mesajı", MessageBoxButtons.YesNo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba", "Bilgi mesajı", MessageBoxButtons.AbortRetryIgnore);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            DialogResult cevap = MessageBox.Show("Bu dosyayı silmek istediğinize emin misiniz ?", "DosyaSil"
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Abort)
            {

            }
        }
    }
}
