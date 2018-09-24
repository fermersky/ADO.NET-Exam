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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

        }

     


        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\starboy.png");
            //pictureBox2.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\wakeup.jpg");
            //pictureBox3.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\redpill.jpg");

            Panel elem = new Panel();
            elem.Size = new Size(1112, 59);
            elem.BackColor = Color.FromArgb(240, 240, 240);
            elem.Location = new Point(50, 730);


            Label id_track_lb = new Label();
            id_track_lb.Text = "7";
            id_track_lb.Location = new Point(12, 18);
            id_track_lb.Font = new Font("Segoe", 12, FontStyle.Regular);
            id_track_lb.Size = new Size(22, 25);

            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(39, 37);
            pb.Location = new Point(44, 10);
            pb.Image = Image
                .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\wakeup.jpg");


            Label trackName = new Label();
            trackName.Text = "Song 1";
            trackName.Size = new Size(127, 24);
            trackName.Location = new Point(101, 18);
            trackName.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            Label trackOwner = new Label();
            trackOwner.Text = "Maroon 5";
            trackOwner.Size = new Size(86, 20);
            trackOwner.Location = new Point(263, 18);
            trackOwner.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            Label trackAlbum = new Label();
            trackAlbum.Text = "Album 5";
            trackAlbum.Size = new Size(132, 20);
            trackAlbum.Location = new Point(450, 18);
            trackAlbum.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            Label trackDuration = new Label();
            trackDuration.Text = "2:28";
            trackDuration.Size = new Size(46, 18);
            trackDuration.Location = new Point(731, 18);
            trackDuration.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            Label trackPrice = new Label();
            trackPrice.Text = "0.99" + "$";
            trackPrice.Size = new Size(52, 20);
            trackPrice.Location = new Point(860, 18);
            trackPrice.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

            MaterialRaisedButton trackBut = new MaterialRaisedButton();
            trackBut.Text = "buy";
            trackBut.Size = new Size(107, 34);
            trackBut.Location = new Point(989, 12);



            elem.Controls.Add(id_track_lb);
            elem.Controls.Add(pb);
            elem.Controls.Add(trackName);
            elem.Controls.Add(trackOwner);
            elem.Controls.Add(trackAlbum);
            elem.Controls.Add(trackDuration);
            elem.Controls.Add(trackPrice);
            elem.Controls.Add(trackBut);

            this.Controls.Add(elem);


        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;

            //MessageBox.Show(but.Parent.Name.ToString());

            foreach (Control item in but.Parent.Controls)
            {
                if (item.Name == "label1")
                {
                    MessageBox.Show(item.Text);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //bin_panel.Location = new Point(this.Width - 200, 63);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Owner = this;

            form.Show();
            //this.Min
        }
    } 
}
