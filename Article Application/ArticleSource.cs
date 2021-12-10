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
    public partial class ArticleSource : Form
    {
        LoginModel user = new LoginModel();
        List<string> Titles = new List<string>();
        private Button buttonAdd = new Button();
        private GroupBox grpboxAdd = new GroupBox();
        private Label labelAdd = new Label();
        private TextBox txtboxAdd = new TextBox();
        string Source;
        public ArticleSource(string source, List<string> t, LoginModel u)
        {
            user = u;
            Titles = t;
            Source = source;
            InitializeComponent();
        }

        private void Techspot_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Loading Form");
            int count = 0;
            int y = 4;
            List<string> Summarys = WebScraper.ScrapeSummary(Source);
            Console.WriteLine("Loading Controls");
            foreach (string title in Titles)
            {
                Console.WriteLine(Titles[count]);

                txtboxAdd = new TextBox();
                txtboxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtboxAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                txtboxAdd.Text = Summarys[count];
                txtboxAdd.Multiline = true;
                txtboxAdd.ReadOnly = true;
                txtboxAdd.Location = new System.Drawing.Point(7, 43);
                txtboxAdd.Size = new System.Drawing.Size(928, 110);

                labelAdd = new Label();
                labelAdd.Text = Titles[count];
                labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelAdd.Location = new System.Drawing.Point(6, 16);
                labelAdd.Size = new System.Drawing.Size(985, 24);

                grpboxAdd = new GroupBox();
                grpboxAdd.Controls.Add(txtboxAdd);
                grpboxAdd.Controls.Add(labelAdd);
                grpboxAdd.Location = new System.Drawing.Point(4, y);
                grpboxAdd.Size = new System.Drawing.Size(959, 194);
                grpboxAdd.Text = "Article";

                panel_ArticlesSelection.Controls.Add(grpboxAdd);

                y += 200;
                count += 1;
            }

            Console.WriteLine("Finished loading form");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Form myForm = new HomeScreen(user);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
