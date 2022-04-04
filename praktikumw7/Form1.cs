using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikumw7
{
    public partial class FormQuiz : Form
    {
        public FormQuiz()
        {
            InitializeComponent();
        }

        private void textBoxHuruf1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxKalimat_TextChanged(object sender, EventArgs e)
        {

        }
        public string hasil;
        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            hasil = "";
            labelHasilAkhir.Text = "";
            textBoxKalimat.Text.ToUpper();
            string aTozB = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] characters = aTozB.ToCharArray();
            string str = textBoxKalimat.Text.ToUpper();
            char[] ch = str.ToCharArray();
            int cek = textBoxHuruf2.Text[0] - textBoxHuruf1.Text[0];
            if (cek < 0)
            {
                cek += 26;
            }
            for (int i = 0; i < ch.Length ; i++)
            {
                if (ch[i] == ' ')
                {
                    hasil += ch[i];
                }
                for (int j = 0; j < 26; j++)
                {
                    if (ch[i] == characters[j])
                    {
                        hasil += characters[j + cek];
                    }
                    
                }
            }
            labelHasilAkhir.Text = hasil.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
