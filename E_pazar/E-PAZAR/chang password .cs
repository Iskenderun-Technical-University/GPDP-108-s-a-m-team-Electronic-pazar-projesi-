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
    public partial class chang_password : Form
    {
        public chang_password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new profile222().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text + '@' + textBox2.Text;
            File.WriteAllText("user.txt", text);
            MessageBox.Show("user name and password has changed ");
        }

        private void chang_password_Load(object sender, EventArgs e)
        {
            
        }

        private void chang_password_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox1.Text + '@' + textBox2.Text;
            File.WriteAllText("user.txt", text);
            MessageBox.Show("user name and password has changed ");
        }
    }
}
