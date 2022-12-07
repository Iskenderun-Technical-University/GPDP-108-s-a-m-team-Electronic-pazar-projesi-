using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_PAZAR
{
    public partial class rgstrform1 : Form
    {
        public rgstrform1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password1.UseSystemPasswordChar = false;
                password2.UseSystemPasswordChar = false;
            }
            else
            {
                password1.UseSystemPasswordChar = true;
                password2.UseSystemPasswordChar = true;
            }
        }

        private void password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void rgstrform1_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rgstrform1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void bottun1_Click(object sender, EventArgs e)
        {
            if(password1.Text == password2.Text)
            {
                new homepage().Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("wrong password !");

            }
        } 

    }
}
