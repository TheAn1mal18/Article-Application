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
    public partial class Login : Form
    {
        List<LoginModel> logins = new List<LoginModel>();
        bool login;
        public Login(bool l)
        {
            login = l;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (login == true)
            {
                button_Finish.Text = "Login";
            }
            else
            {
                button_Finish.Text = "Sign Up";

                this.Controls.Remove(textBox_UserID);
                textBox_UserID.Dispose();
                this.Controls.Remove(label3);
                label3.Dispose();
            }
        }

        private void button_Finish_Click(object sender, EventArgs e)
        {
            if (login == true)
            {
                LoginModel checker = new LoginModel();
                foreach (LoginModel login in logins)
                {
                    if (login.UserId == Convert.ToInt32(textBox_UserID.Text))
                    {
                        checker = login;
                        return;
                    }
                }
                if (checker.UserName == textBox_Username.Text && checker.Password == textBox_Password.Text)
                {
                    Form myForm = new HomeScreen(checker);
                    this.Hide();
                    myForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have input an incorrect password or username", "Incorrect Login");
                }
            }
            else
            {
                LoginModel person = new LoginModel();
                person.UserName = textBox_Username.Text;
                person.Password = textBox_Password.Text;

                SQLiteDataAccess.SavePerson(person);

                Form myForm = new HomeScreen(person);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Form myForm = new HomeScreen(null);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
