using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Exam
{
    public partial class Form3 : MaterialForm
    {
        private int CurrentPage { get; set; } = 0;
        private List<Books> BooksSet;

        public double MaxPages { get; set; }
        public int CurrId { get; set; }
        public string imgPath { get; set; }

        public Form3()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
           // materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);


            using (ShopEntities db = new ShopEntities())
            {
                BooksSet = (from b in db.Books
                            where b.IsDeleted != true
                            orderby b.Id
                            select b).Include("Authors").Include("Genres").ToList();


                double d = Convert.ToDouble(BooksSet.Count) / 6.0;
                MaxPages = Math.Ceiling(d);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowPageOfBooks(BooksSet);
        }

        private void GeneratePagination()
        {
            paginationPanel.Controls.Clear();
            using (ShopEntities db = new ShopEntities())
            {
                double d = Convert.ToDouble(db.Books.Where(b => b.IsDeleted !=true).Count()) / 6.0;
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
        }

        private void But_MouseClick(object sender, MouseEventArgs e)
        {
            MaterialRaisedButton but = sender as MaterialRaisedButton;
            CurrentPage = int.Parse(but.Text) - 1;
            using (ShopEntities db = new ShopEntities())
            {
                ShowPageOfBooks(db.Books.ToList());
            }
        }

        private void ShowPageOfBooks(List<Books> _books)
        {
            GeneratePagination();

            using (ShopEntities db = new ShopEntities())
            {
                int marginTop = 74;
                int startHeight = 0;

                var Books = (from d in _books
                             where d.IsDeleted != true
                             select d).Skip(CurrentPage * 6).Take(6).ToList();
                mainPanel.Controls.Clear();

                for (int i = 0; i < Books.Count(); i++)
                {
                    if (Books[i].Title != null)
                    {
                        Panel elem = new Panel();
                        elem.Size = new Size(1002, 59);
                        elem.BackColor = Color.FromArgb(240, 240, 240);
                        elem.Location = new Point(30, startHeight);

                        startHeight += marginTop;

                        // Id

                        Label bookId = new Label();
                        bookId.Text = Books[i].Id.ToString();
                        bookId.Location = new Point(12, 18);
                        bookId.Font = new Font("Segoe", 12, FontStyle.Regular);
                        bookId.Size = new Size(32, 25);
                        bookId.Name = "id_book";

                        PictureBox pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Size = new Size(29, 37);
                        pb.Location = new Point(54, 10);
                        pb.Image = Image
                            .FromFile(Books[i].ImagePath);

                        // Title

                        Label bookTitle = new Label();
                        bookTitle.Text = Books[i].Title;
                        bookTitle.Size = new Size(207, 34);
                        bookTitle.Location = new Point(101, 18);
                        bookTitle.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                        // Author Name

                        Label bookAuthor = new Label();
                        bookAuthor.Text = Books[i].Authors.FirstName + " " + Books[i].Authors.LastName;
                        bookAuthor.Size = new Size(156, 30);
                        bookAuthor.Location = new Point(313, 18);
                        bookAuthor.Font = new Font("Segoe UI", 12f, FontStyle.Regular);


                        MaterialRaisedButton editBut = new MaterialRaisedButton();
                        editBut.Text = "✎";
                        editBut.Size = new Size(38, 38);
                        editBut.Location = new Point(880, 12);
                        editBut.MouseClick += EditBut_MouseClick;

                        MaterialRaisedButton delBut = new MaterialRaisedButton();
                        delBut.Text = "x";
                        delBut.Size = new Size(38, 38);
                        delBut.Location = new Point(930, 12);
                        delBut.Click += DelBut_Click;



                        elem.Controls.Add(bookId);
                        elem.Controls.Add(pb);
                        elem.Controls.Add(bookTitle);
                        elem.Controls.Add(bookAuthor);
                        elem.Controls.Add(editBut);
                        elem.Controls.Add(delBut);

                        mainPanel.Controls.Add(elem);
                    }
                }
            }
        }

        private void DelBut_Click(object sender, EventArgs e) // delete but
        {
            MaterialRaisedButton but = sender as MaterialRaisedButton;

            foreach (Control item in but.Parent.Controls)
            {
                if (item.Name == "id_book")
                    CurrId = Convert.ToInt32(item.Text);
            }

            using (ShopEntities db = new ShopEntities())
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Book?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    var toDelete = db.Books.Where(b => b.Id == CurrId).First();
                    toDelete.IsDeleted = true;
                    db.SaveChanges();
                }

                ShowPageOfBooks(db.Books.ToList());
            }
        }

        private void EditBut_MouseClick(object sender, MouseEventArgs e) // edit but
        {

            rightPanel.Visible = true;
            saveBut.Visible = true;
            addBut.Visible = false;



            MaterialRaisedButton but = sender as MaterialRaisedButton;

            foreach (Control item in but.Parent.Controls)
            {
                if (item.Name == "id_book")
                    CurrId = Convert.ToInt32(item.Text);
            }

            using (ShopEntities db = new ShopEntities())
            {
                var book = db.Books
                    .Where(b => b.Id == CurrId)
                    .First();

                imgPath = book.ImagePath;

                bookAlbum.Image = Image.FromFile(book.ImagePath);
                title_tb.Text = book.Title;
                price_tb.Text = book.Price;
                publ_tb.Text = book.Publisher;
                pages_tb.Text = book.Pages.ToString();
                sequel_Tb.Text = book.IsSequel;


                var genres = db.Genres.Select(g => new { Genre = g.GenreName }).ToList();
                genres_cb.Items.Clear();
                foreach (var item in genres)
                    genres_cb.Items.Add(item.Genre);

                var authors = db.Authors.Select(g => new { FN = g.FirstName, LN = g.LastName }).ToList();
                authors_tb.Items.Clear();
                foreach (var item in authors)
                    authors_tb.Items.Add(item.FN + " " + item.LN);

                genres_cb.Text = book.Genres.GenreName;
                authors_tb.Text = book.Authors.FirstName + " " + book.Authors.LastName;
            }
        }


        private void materialFlatButton2_Click(object sender, EventArgs e) // next page
        {
            if (CurrentPage < MaxPages - 1)
            {
                CurrentPage += 1;
                using (ShopEntities db = new ShopEntities())
                    ShowPageOfBooks(db.Books.ToList());
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e) // prev page
        {
            if (CurrentPage >= 1)
            {
                CurrentPage -= 1;
                using (ShopEntities db = new ShopEntities())
                    ShowPageOfBooks(db.Books.ToList());
            }
        }



        private void materialRaisedButton1_Click(object sender, EventArgs e) // SaveChanges
        {
            using (ShopEntities db = new ShopEntities())
            {
                var currBook = db.Books
                        .Where(b => b.Id == CurrId).First();

                var genreId = db.Genres.Where(g => g.GenreName == genres_cb.Text).First();
                var authorId = db.Authors.Where(g => g.FirstName + " " + g.LastName == authors_tb.Text).First();

                var willEdit = db.Books.Where(c => c.Id == CurrId).First();

                willEdit.Discount = currBook.Discount;
                willEdit.IsDeleted = false;
                willEdit.IsSequel = sequel_Tb.Text;
                willEdit.PublishDate = currBook.PublishDate;
                willEdit.PriceForSale = currBook.Price;
                willEdit.Pages = int.Parse(pages_tb.Text);
                willEdit.ImagePath = imgPath;

                willEdit.Title = title_tb.Text;
                willEdit.Price = price_tb.Text;
                willEdit.Publisher = publ_tb.Text;

                willEdit.Id_Genre = genreId.Id;
                willEdit.Id_Author = authorId.Id;

                db.SaveChanges();
                ShowPageOfBooks(db.Books.ToList());
            }

            rightPanel.Visible = false;
           
            

        }



        private void materialRaisedButton2_Click(object sender, EventArgs e) // Change Photo Button
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imgPath = Path.GetFileName(dialog.FileName);
            }

            bookAlbum.Image = Image.FromFile(imgPath);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e) // fill fileds before add
        {
            bookAlbum.Image = Image.FromFile("default.jpg");
            rightPanel.Visible = true;
            saveBut.Visible = false;
            addBut.Visible = true;

            genres_cb.Items.Clear();
            authors_tb.Items.Clear();

            imgPath = "default.jpg";

            foreach (Control item in rightPanel.Controls)
            {
                if (item.GetType() == typeof(MaterialSingleLineTextField))
                {
                    item.Text = "";
                }
            }

            using (ShopEntities db = new ShopEntities())
            {
                var genres = db.Genres.Select(g => new { Genre = g.GenreName }).ToList();
                foreach (var item in genres)
                    genres_cb.Items.Add(item.Genre);


                var authors = db.Authors.Select(g => new { FN = g.FirstName, LN = g.LastName }).ToList();
                foreach (var item in authors)
                    authors_tb.Items.Add(item.FN + " " + item.LN);
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e) // add book
        {
            
            using (ShopEntities db = new ShopEntities())
            {
                var genreId = db.Genres.Where(g => g.GenreName == genres_cb.Text).First();
                var authorId = db.Authors.Where(g => g.FirstName + " " + g.LastName == authors_tb.Text).First();

                Books newBook = new Books()
                {
                    Discount = 0,
                    IsDeleted = false,
                    IsSequel = sequel_Tb.Text,
                    PublishDate = DateTime.Now,
                    PriceForSale = price_tb.Text,
                    Pages = int.Parse(pages_tb.Text),
                    ImagePath = imgPath,

                    Title = title_tb.Text,
                    Price = price_tb.Text,
                    Publisher = publ_tb.Text,

                    Id_Genre = genreId.Id,
                    Id_Author = authorId.Id
                };

                db.Books.Add(newBook);
                db.SaveChanges();
                ShowPageOfBooks(db.Books.ToList());
            }
        }
    }
}
