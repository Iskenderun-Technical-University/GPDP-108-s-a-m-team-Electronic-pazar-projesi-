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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            
        }

        private void homepage_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel5.Width) / 2;
            int y = (this.Height - panel5.Height) / 2;
            panel5.Location = new Point(x, y);
        }

        private void button22_Click_3(object sender, EventArgs e)
        {
            if(MessageBox.Show("DO YOU WANT TO LOGOUT ? ","LOGOUT",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_3(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addcontrolstopanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            Controlpanel111.Controls.Clear();
            Controlpanel111.Controls.Add(c);

        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            home111 pazarhome = new home111();
            addcontrolstopanel(pazarhome);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            profile222 pp = new profile222();
            addcontrolstopanel(pp);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DO YOU WANT TO LOGOUT ? ", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Form1().Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addpost333 pp = new addpost333();
            addcontrolstopanel(pp);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pazarmessage pp = new pazarmessage();
            addcontrolstopanel(pp);
        }
    }
}
