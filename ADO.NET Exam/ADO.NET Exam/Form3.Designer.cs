namespace ADO.NET_Exam
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.title_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bookAlbum = new System.Windows.Forms.PictureBox();
            this.price_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.publ_tb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.genres_cb = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.authors_tb = new MetroFramework.Controls.MetroComboBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(21, 200);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(709, 521);
            this.mainPanel.TabIndex = 45;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(411, 157);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 41;
            this.materialLabel3.Text = "Автор";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(156, 157);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 40;
            this.materialLabel2.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 39;
            // 
            // paginationPanel
            // 
            this.paginationPanel.Location = new System.Drawing.Point(517, 791);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Size = new System.Drawing.Size(266, 39);
            this.paginationPanel.TabIndex = 48;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(881, 795);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(26, 36);
            this.materialFlatButton2.TabIndex = 47;
            this.materialFlatButton2.Text = ">>";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(401, 795);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(26, 36);
            this.materialFlatButton1.TabIndex = 46;
            this.materialFlatButton1.Text = "<<";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rightPanel.Controls.Add(this.materialRaisedButton2);
            this.rightPanel.Controls.Add(this.materialLabel7);
            this.rightPanel.Controls.Add(this.materialLabel5);
            this.rightPanel.Controls.Add(this.authors_tb);
            this.rightPanel.Controls.Add(this.materialLabel6);
            this.rightPanel.Controls.Add(this.genres_cb);
            this.rightPanel.Controls.Add(this.materialRaisedButton1);
            this.rightPanel.Controls.Add(this.materialLabel4);
            this.rightPanel.Controls.Add(this.publ_tb);
            this.rightPanel.Controls.Add(this.materialLabel1);
            this.rightPanel.Controls.Add(this.price_tb);
            this.rightPanel.Controls.Add(this.bookAlbum);
            this.rightPanel.Controls.Add(this.title_tb);
            this.rightPanel.Location = new System.Drawing.Point(1179, 64);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(441, 1620);
            this.rightPanel.TabIndex = 49;
            this.rightPanel.Visible = false;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // title_tb
            // 
            this.title_tb.Depth = 0;
            this.title_tb.Hint = "";
            this.title_tb.Location = new System.Drawing.Point(135, 298);
            this.title_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_tb.Name = "title_tb";
            this.title_tb.PasswordChar = '\0';
            this.title_tb.SelectedText = "";
            this.title_tb.SelectionLength = 0;
            this.title_tb.SelectionStart = 0;
            this.title_tb.Size = new System.Drawing.Size(252, 23);
            this.title_tb.TabIndex = 0;
            this.title_tb.UseSystemPasswordChar = false;
            // 
            // bookAlbum
            // 
            this.bookAlbum.Location = new System.Drawing.Point(146, 23);
            this.bookAlbum.Name = "bookAlbum";
            this.bookAlbum.Size = new System.Drawing.Size(145, 219);
            this.bookAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookAlbum.TabIndex = 1;
            this.bookAlbum.TabStop = false;
            // 
            // price_tb
            // 
            this.price_tb.Depth = 0;
            this.price_tb.Hint = "";
            this.price_tb.Location = new System.Drawing.Point(135, 344);
            this.price_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.price_tb.Name = "price_tb";
            this.price_tb.PasswordChar = '\0';
            this.price_tb.SelectedText = "";
            this.price_tb.SelectionLength = 0;
            this.price_tb.SelectionStart = 0;
            this.price_tb.Size = new System.Drawing.Size(252, 23);
            this.price_tb.TabIndex = 50;
            this.price_tb.UseSystemPasswordChar = false;
            // 
            // publ_tb
            // 
            this.publ_tb.Depth = 0;
            this.publ_tb.Hint = "";
            this.publ_tb.Location = new System.Drawing.Point(135, 394);
            this.publ_tb.MouseState = MaterialSkin.MouseState.HOVER;
            this.publ_tb.Name = "publ_tb";
            this.publ_tb.PasswordChar = '\0';
            this.publ_tb.SelectedText = "";
            this.publ_tb.SelectionLength = 0;
            this.publ_tb.SelectionStart = 0;
            this.publ_tb.Size = new System.Drawing.Size(252, 23);
            this.publ_tb.TabIndex = 50;
            this.publ_tb.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(36, 615);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(154, 42);
            this.materialRaisedButton1.TabIndex = 51;
            this.materialRaisedButton1.Text = "Save Changes";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // genres_cb
            // 
            this.genres_cb.FormattingEnabled = true;
            this.genres_cb.ItemHeight = 23;
            this.genres_cb.Location = new System.Drawing.Point(135, 453);
            this.genres_cb.Name = "genres_cb";
            this.genres_cb.Size = new System.Drawing.Size(252, 29);
            this.genres_cb.TabIndex = 52;
            this.genres_cb.UseSelectable = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 302);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "Title";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(32, 348);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(43, 19);
            this.materialLabel4.TabIndex = 51;
            this.materialLabel4.Text = "Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 453);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 52;
            this.materialLabel5.Text = "Genre";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(32, 398);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(71, 19);
            this.materialLabel6.TabIndex = 53;
            this.materialLabel6.Text = "Publisher";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(32, 511);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(62, 19);
            this.materialLabel7.TabIndex = 53;
            this.materialLabel7.Text = "Authors";
            // 
            // authors_tb
            // 
            this.authors_tb.FormattingEnabled = true;
            this.authors_tb.ItemHeight = 23;
            this.authors_tb.Location = new System.Drawing.Point(135, 511);
            this.authors_tb.Name = "authors_tb";
            this.authors_tb.Size = new System.Drawing.Size(252, 29);
            this.authors_tb.TabIndex = 54;
            this.authors_tb.UseSelectable = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(182, 248);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton2.TabIndex = 55;
            this.materialRaisedButton2.Text = "change";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 873);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.paginationPanel);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.label4);
            this.Name = "Form3";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paginationPanel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel rightPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField publ_tb;
        private MaterialSkin.Controls.MaterialSingleLineTextField price_tb;
        private System.Windows.Forms.PictureBox bookAlbum;
        private MaterialSkin.Controls.MaterialSingleLineTextField title_tb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MetroFramework.Controls.MetroComboBox genres_cb;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MetroFramework.Controls.MetroComboBox authors_tb;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}