using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aslogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Closed the Screen :)");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((username.Text == "luxury") && (password.Text == "luxury123"))
            {
                new Form2().Show();
                this.Hide();
            }
            else if ((username.Text == "games") && (password.Text == "games123"))
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login :)");
                this.Hide();
            }
        } 
    }
}