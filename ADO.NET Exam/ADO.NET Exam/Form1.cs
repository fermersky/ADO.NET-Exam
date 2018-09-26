using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Exam
{
    public partial class Form1 : MaterialForm
    {

        private int CurrentPage { get; set; } = 0;
        private List<Books> BooksSet;

        public double MaxPages { get; set; }


        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

            using (LibraryEntities db = new LibraryEntities())
            {
                BooksSet = (from b in db.Books
                            orderby b.Id
                            select b).Include("Authors").Include("Genres").ToList();


                double d = Convert.ToDouble(BooksSet.Count) / 6.0;
                MaxPages = Math.Ceiling(d);
            }

            Form3 form = new Form3();
            form.ShowDialog();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\starboy.png");
            //pictureBox2.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\wakeup.jpg");
            //pictureBox3.Image = Image
            //    .FromFile(@"C:\Users\Данил\Desktop\ADO.NET Exam\ADO.NET Exam\bin\Debug\redpill.jpg");

            GeneratePagination(BooksSet);
            ShowPageOfBooks(BooksSet);
        }

        private void GeneratePagination(List<Books> _books)
        {
            double d = Convert.ToDouble(BooksSet.Count) / 6.0;
            MaxPages = Math.Ceiling(d);

            int locy = 3;
            for (int i = 1; i <= MaxPages; i++)
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
            ShowPageOfBooks(BooksSet);
        }

        private void ShowPageOfBooks(List<Books> _books)
        {
            GeneratePagination(_books);

            using (LibraryEntities db = new LibraryEntities())
            {
                int marginTop = 74;
                int startHeight = 0;

                var Books = (from d in _books
                             select d).Skip(CurrentPage * 6).Take(6).ToList();
                mainPanel.Controls.Clear();

                for (int i = 0; i < Books.Count(); i++)
                {
                    if (Books[i].Title != null)
                    {
                        Panel elem = new Panel();
                        elem.Size = new Size(1212, 59);
                        elem.BackColor = Color.FromArgb(240, 240, 240);
                        elem.Location = new Point(30, startHeight);

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
            if (CurrentPage < MaxPages - 1)
            {
                CurrentPage += 1;
                ShowPageOfBooks(BooksSet);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (CurrentPage >= 1)
            {
                CurrentPage -= 1;
                ShowPageOfBooks(BooksSet);
            }
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            CurrentPage = 0;
            if (Title_radio.Checked)
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var filtered = (from b in db.Books
                                    where b.Title.Contains(search_field.Text)
                                    orderby b.Id
                                    select b
                                    ).Include("Authors").Include("Genres").ToList();
                    paginationPanel.Controls.Clear();
                    BooksSet = filtered;
                    ShowPageOfBooks(BooksSet);
                }
            }
            else if (Author_radio.Checked)
            {
                using (LibraryEntities db = new LibraryEntities())
                {
                    var filtered = (from b in db.Books
                                    where b.Authors.FirstName.Contains(search_field.Text) ||
                                          b.Authors.LastName.Contains(search_field.Text)
                                    orderby b.Id
                                    select b)
                                    .Include("Authors")
                                    .Include("Genres")
                                    .ToList();

                    paginationPanel.Controls.Clear();
                    BooksSet = filtered;
                    ShowPageOfBooks(BooksSet);
                }
            }
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    } 
}
