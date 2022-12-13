using System.IO;

namespace E_PAZAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string text = File.ReadAllText("user.txt");

            string[] str = text.Split('@');
            string username = str[0];
            string password = str[1];

            if (textBox1.Text.Equals(username) && password1.Text.Equals(password))
            {
                new homepage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password ! " + "try again");
                textBox1.Text = null;
                password1.Text = null;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new rgstrform1().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                password1.UseSystemPasswordChar = false;
            }
            else
            {
                password1.UseSystemPasswordChar = true;
            }
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void password1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}