using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article_Application
{
    public partial class HomeScreen : Form
    {
        LoginModel user = new LoginModel();
        List<string> t;
        public HomeScreen(LoginModel info)
        {
            InitializeComponent();
            if (info != null)
            {
                label1.Text = $"Welcome {info.UserName}";
                button_Login.Enabled = false;
                button_SignUp.Enabled = false;
                button_Signout.Enabled = true;
            }
            user = info;
        }

        private void button_Engagdet_Click(object sender, EventArgs e)
        {
            t = WebScraper.ScrapeTitles("engadget");
            Form myForm = new ArticleSource("engadget", t, user);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            Form myForm = new Login(false);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Form myForm = new Login(true);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button_Techspot_Click(object sender, EventArgs e)
        {
            t = WebScraper.ScrapeTitles("techspot");
            Form myForm = new ArticleSource("techspot", t, user);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
