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

        public int CurrentPage { get; set; } = 0;
        public int MaxPages { get; set; }

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

            using (LibraryEntities db = new LibraryEntities())
            {
                MaxPages = db.Books.Count() / 6;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\starboy.png");
            //pictureBox2.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\wakeup.jpg");
            //pictureBox3.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\redpill.jpg");

            GeneratePagination();
            ShowPageOfBooks();
        }

        private void GeneratePagination()
        {
            int locy = 3;
            for (int i = 1; i <= MaxPages + 1; i++)
            {
                MaterialRaisedButton but = new MaterialRaisedButton();
                but.Text = i.ToString();
                but.Location = new Point(locy, 3);
                but.Size = new Size(38, 38);
                but.MouseClick += But_MouseClick;
                paginationPanel.Controls.Add(but);

                locy += 43;
            }         
        }

        private void But_MouseClick(object sender, MouseEventArgs e)
        {
            MaterialRaisedButton but = sender as MaterialRaisedButton;
            CurrentPage = int.Parse(but.Text) - 1;
            ShowPageOfBooks();
        }

        private void ShowPageOfBooks()
        {
            //MessageBox.Show(CurrentPage.ToString());
            using (LibraryEntities db = new LibraryEntities())
            {
                int marginTop = 74;
                int startHeight = 0;

                var Books = (from d in db.Books
                             orderby d.Id
                             select d).Skip(CurrentPage * 6).Take(6).ToList();
                mainPanel.Controls.Clear();

                for (int i = 0; i < Books.Count(); i++)
                {
                    if (Books[i].Title != null)
                    {
                        Panel elem = new Panel();
                        elem.Size = new Size(1212, 59);
                        elem.BackColor = Color.FromArgb(240, 240, 240);
                        elem.Location = new Point(50, startHeight);

                        startHeight += marginTop;

                        // Id

                        Label bookId = new Label();
                        bookId.Text = Books[i].Id.ToString();
                        bookId.Location = new Point(12, 18);
                        bookId.Font = new Font("Segoe", 12, FontStyle.Regular);
                        bookId.Size = new Size(32, 25);

                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Size = new Size(29, 37);
                        pb.Location = new Point(54, 10);
                        pb.Image = Image
                            .FromFile(Books[i].ImagePath);

                        // Title

                        Label bookTitle = new Label();
                        bookTitle.Text = Books[i].Title;
                        bookTitle.Size = new Size(227, 34);
                        bookTitle.Location = new Point(101, 18);
                        bookTitle.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        // Author Name

                        Label bookAuthor = new Label();
                        bookAuthor.Text = Books[i].Authors.FirstName + " " + Books[i].Authors.LastName;
                        bookAuthor.Size = new Size(186, 30);
                        bookAuthor.Location = new Point(363, 18);
                        bookAuthor.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        // Genre

                        Label bookGenre = new Label();
                        bookGenre.Text = Books[i].Genres.GenreName;
                        bookGenre.Size = new Size(132, 20);
                        bookGenre.Location = new Point(650, 18);
                        bookGenre.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        // Pages

                        Label bookPages = new Label();
                        bookPages.Text = Books[i].Pages.ToString();
                        bookPages.Size = new Size(46, 18);
                        bookPages.Location = new Point(831, 18);
                        bookPages.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        // Price

                        Label bookPrice = new Label();
                        bookPrice.Text = Books[i].PriceForSale + "$";
                        bookPrice.Size = new Size(52, 20);
                        bookPrice.Location = new Point(960, 18);
                        bookPrice.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        MaterialRaisedButton trackBut = new MaterialRaisedButton();
                        trackBut.Text = "buy";
                        trackBut.Size = new Size(107, 34);
                        trackBut.Location = new Point(1089, 12);



                        elem.Controls.Add(bookId);
                        elem.Controls.Add(pb);
                        elem.Controls.Add(bookTitle);
                        elem.Controls.Add(bookAuthor);
                        elem.Controls.Add(bookGenre);
                        elem.Controls.Add(bookPages);
                        elem.Controls.Add(bookPrice);
                        elem.Controls.Add(trackBut);

                        mainPanel.Controls.Add(elem);
                    }
                }
            }
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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPages)
            {
                CurrentPage += 1;
                ShowPageOfBooks();
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (CurrentPage >= 1)
            {
                CurrentPage -= 1;
                ShowPageOfBooks();
            }
        }
    } 
}
