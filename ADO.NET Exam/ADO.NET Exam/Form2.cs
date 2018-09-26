using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Exam
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            login_tb.Text = "volodya";
            pass_tb.Text = "bes1_admin";

            login_tb_Enter(this, new EventArgs());
            pass_tb_Enter(this, new EventArgs());
        }

        private void login_tb_Enter(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1;
            timer.Start();

            label1.Visible = false;
            label2.Visible = false;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            if (materialLabel1.Location.Y >= 292)
                materialLabel1.Location =
                    new Point(materialLabel1.Location.X, materialLabel1.Location.Y - 3);
            else
                t.Stop();

        }

        private void login_tb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_tb.Text))
            {
                Timer timer = new Timer();
                timer.Tick += Timer_Tick2;
                timer.Interval = 1;
                timer.Start();
            }
        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            if (materialLabel1.Location.Y <= 311)
                materialLabel1.Location =
                    new Point(materialLabel1.Location.X, materialLabel1.Location.Y + 3);
            else
                t.Stop();
        }

        private void pass_tb_Enter(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += Timer_Tick3;
            timer.Interval = 1;
            timer.Start();

            label1.Visible = false;
            label2.Visible = false;
        }

        private void Timer_Tick3(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            if (materialLabel2.Location.Y >= 355)
                materialLabel2.Location =
                    new Point(materialLabel2.Location.X, materialLabel2.Location.Y - 3);
            else
                t.Stop();
        }

        private void pass_tb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pass_tb.Text))
            {
                Timer timer = new Timer();
                timer.Tick += Timer_Tick4;
                timer.Interval = 1;
                timer.Start();
            }
        }

        private void Timer_Tick4(object sender, EventArgs e)
        {
            Timer t = sender as Timer;
            if (materialLabel2.Location.Y <= 379)
                materialLabel2.Location =
                    new Point(materialLabel2.Location.X, materialLabel2.Location.Y + 3);
            else
                t.Stop();
        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Owner.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                if (this.Text == "Login admin")
                {
                    try
                    {
                        var users = (from u in db.Admins
                                     where u.Lgn == login_tb.Text
                                     && u.Pwd == pass_tb.Text
                                     select u.Id).First();

                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loh");
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                }
                else if (this.Text == "Login user")
                {
                    try
                    {
                        var users = (from u in db.Users
                                     where u.Lgn == login_tb.Text
                                     && u.Pwd == pass_tb.Text
                                     select new { u.Id, u.Lgn }).First();

                        this.Close();

                        Form1 form = this.Owner as Form1;
                        form.CurrUserName = users.Lgn;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Loh");
                        label1.Visible = true;
                        label2.Visible = true;
                    }
                }

                
            }
        }
    }
}
