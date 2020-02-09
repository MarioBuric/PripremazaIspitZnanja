using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricmariopripremazaispit2zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonPosalji_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxIme.Text + " " + textBoxPrezime.Text);
        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrezime_TextChanged_1(object sender, EventArgs e)
        {

        }
        
}

    }



