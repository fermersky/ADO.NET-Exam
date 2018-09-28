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
    public partial class Form5 : MaterialForm
    {
        public int CountInBin { get; set; } = 0;
        public Form5()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form1 form = this.Owner as Form1;
            var Books = form.Bin.Books.Select(b => new { Price = b.Price });

            double sum = 0;

            foreach (var item in Books)
                sum += double.Parse(item.Price);

            sum_lb.Text = sum + "$";
            ShowPageOfBooks();
        }

        private void ShowPageOfBooks()
        {
            Form1 form = this.Owner as Form1;
            var Books = form.Bin.Books;
            using (ShopEntities db = new ShopEntities())
            {
                int marginTop = 74;
                int startHeight = 0;

                mainPanel.Controls.Clear();

                for (int i = 0; i < Books.Count(); i++)
                {
                    if (Books[i].Title != null)
                    {
                        Panel elem = new Panel();
                        elem.Size = new Size(1262, 59);
                        elem.BackColor = Color.FromArgb(240, 240, 240);
                        elem.Location = new Point(0, startHeight);

                        startHeight += marginTop;

                        // Id

                        Label bookId = new Label();
                        bookId.Text = Books[i].Id.ToString();
                        bookId.Location = new Point(12, 18);
                        bookId.Font = new Font("Segoe", 12, FontStyle.Regular);
                        bookId.Size = new Size(32, 25);
                        bookId.Name = "id_book_lb";

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
                        bookPrice.Text = Books[i].Price + "$";
                        bookPrice.Size = new Size(52, 20);
                        bookPrice.Location = new Point(1060, 18);
                        bookPrice.Font = new Font("Segoe UI", 12f, FontStyle.Regular);



                        //★



                        elem.Controls.Add(bookId);
                        elem.Controls.Add(pb);
                        elem.Controls.Add(bookTitle);
                        elem.Controls.Add(bookAuthor);
                        elem.Controls.Add(bookGenre);
                        elem.Controls.Add(bookPages);
                        elem.Controls.Add(bookPrice);


                        mainPanel.Controls.Add(elem);
                    }
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Form1 form = this.Owner as Form1;
            form.count_within.Text = "0";
            form.Bin.Books.Clear();

            CountInBin = 0;
            ShowPageOfBooks();
            count_within.Text = "0";
            sum_lb.Text = "0$";
        }
    }
}
