namespace VideoRentalProject
{
    partial class MainForm
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.LoadMovies = new System.Windows.Forms.Button();
            this.FNBox = new System.Windows.Forms.TextBox();
            this.LNBox = new System.Windows.Forms.TextBox();
            this.AdBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CustomerIdBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.MovIdBox = new System.Windows.Forms.TextBox();
            this.ReturnMovieBtn = new System.Windows.Forms.Button();
            this.IssueMovieBtn = new System.Windows.Forms.Button();
            this.LoadRentedMovies = new System.Windows.Forms.Button();
            this.PopCustBtn = new System.Windows.Forms.Button();
            this.PopMovBtn = new System.Windows.Forms.Button();
            this.AddMovBtn = new System.Windows.Forms.Button();
            this.UpdateMovBtn = new System.Windows.Forms.Button();
            this.DeleteMovBtn = new System.Windows.Forms.Button();
            this.GenBox = new System.Windows.Forms.TextBox();
            this.PlotBox = new System.Windows.Forms.TextBox();
            this.CopBox = new System.Windows.Forms.TextBox();
            this.RenCosBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.TitBox = new System.Windows.Forms.TextBox();
            this.RatBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RCLabel = new System.Windows.Forms.Label();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(16, 15);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(109, 66);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Customers";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(16, 89);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 51;
            this.MainGrid.Size = new System.Drawing.Size(872, 361);
            this.MainGrid.TabIndex = 1;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick_1);
            // 
            // LoadMovies
            // 
            this.LoadMovies.Location = new System.Drawing.Point(133, 15);
            this.LoadMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadMovies.Name = "LoadMovies";
            this.LoadMovies.Size = new System.Drawing.Size(109, 66);
            this.LoadMovies.TabIndex = 2;
            this.LoadMovies.Text = "Load Movies";
            this.LoadMovies.UseVisualStyleBackColor = true;
            this.LoadMovies.Click += new System.EventHandler(this.LoadMovies_Click);
            // 
            // FNBox
            // 
            this.FNBox.Location = new System.Drawing.Point(504, 495);
            this.FNBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FNBox.Name = "FNBox";
            this.FNBox.Size = new System.Drawing.Size(132, 22);
            this.FNBox.TabIndex = 3;
            this.FNBox.TextChanged += new System.EventHandler(this.FNTBox_TextChanged);
            // 
            // LNBox
            // 
            this.LNBox.Location = new System.Drawing.Point(363, 546);
            this.LNBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LNBox.Name = "LNBox";
            this.LNBox.Size = new System.Drawing.Size(132, 22);
            this.LNBox.TabIndex = 4;
            this.LNBox.TextChanged += new System.EventHandler(this.LNBox_TextChanged);
            // 
            // AdBox
            // 
            this.AdBox.Location = new System.Drawing.Point(504, 546);
            this.AdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdBox.Name = "AdBox";
            this.AdBox.Size = new System.Drawing.Size(132, 22);
            this.AdBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(645, 546);
            this.PhoneBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(132, 22);
            this.PhoneBox.TabIndex = 6;
            this.PhoneBox.Text = " ";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(504, 475);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(76, 17);
            this.FNLabel.TabIndex = 7;
            this.FNLabel.Text = "First Name";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(359, 527);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(76, 17);
            this.LNLabel.TabIndex = 8;
            this.LNLabel.Text = "Last Name";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(500, 527);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(60, 17);
            this.AdLabel.TabIndex = 9;
            this.AdLabel.Text = "Address";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(641, 527);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(49, 17);
            this.PhLabel.TabIndex = 10;
            this.PhLabel.Text = "Phone";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(16, 473);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(83, 66);
            this.AddCustBtn.TabIndex = 11;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.Location = new System.Drawing.Point(107, 473);
            this.UpdCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(83, 66);
            this.UpdCustBtn.TabIndex = 12;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = true;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(363, 475);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(85, 17);
            this.CustIDLabel.TabIndex = 14;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.Enabled = false;
            this.CustomerIdBox.Location = new System.Drawing.Point(363, 495);
            this.CustomerIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.Size = new System.Drawing.Size(132, 22);
            this.CustomerIdBox.TabIndex = 13;
            this.CustomerIdBox.TextChanged += new System.EventHandler(this.CustomerIdBox_TextChanged);
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.Location = new System.Drawing.Point(197, 473);
            this.DltCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(83, 66);
            this.DltCustBtn.TabIndex = 15;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = true;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(363, 599);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(62, 17);
            this.MovieIDLabel.TabIndex = 17;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // MovIdBox
            // 
            this.MovIdBox.Enabled = false;
            this.MovIdBox.Location = new System.Drawing.Point(363, 619);
            this.MovIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovIdBox.Name = "MovIdBox";
            this.MovIdBox.Size = new System.Drawing.Size(132, 22);
            this.MovIdBox.TabIndex = 16;
            // 
            // ReturnMovieBtn
            // 
            this.ReturnMovieBtn.Location = new System.Drawing.Point(779, 15);
            this.ReturnMovieBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnMovieBtn.Name = "ReturnMovieBtn";
            this.ReturnMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.ReturnMovieBtn.TabIndex = 18;
            this.ReturnMovieBtn.Text = "Return Movie";
            this.ReturnMovieBtn.UseVisualStyleBackColor = true;
            this.ReturnMovieBtn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // IssueMovieBtn
            // 
            this.IssueMovieBtn.Location = new System.Drawing.Point(661, 15);
            this.IssueMovieBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssueMovieBtn.Name = "IssueMovieBtn";
            this.IssueMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.IssueMovieBtn.TabIndex = 19;
            this.IssueMovieBtn.Text = "Issue Movie";
            this.IssueMovieBtn.UseVisualStyleBackColor = true;
            this.IssueMovieBtn.Click += new System.EventHandler(this.IssueMovieBtn_Click);
            // 
            // LoadRentedMovies
            // 
            this.LoadRentedMovies.Location = new System.Drawing.Point(251, 15);
            this.LoadRentedMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadRentedMovies.Name = "LoadRentedMovies";
            this.LoadRentedMovies.Size = new System.Drawing.Size(109, 66);
            this.LoadRentedMovies.TabIndex = 20;
            this.LoadRentedMovies.Text = "Load Rented Movies";
            this.LoadRentedMovies.UseVisualStyleBackColor = true;
            this.LoadRentedMovies.Click += new System.EventHandler(this.LoadRentedMovies_Click);
            // 
            // PopCustBtn
            // 
            this.PopCustBtn.Location = new System.Drawing.Point(504, 15);
            this.PopCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopCustBtn.Name = "PopCustBtn";
            this.PopCustBtn.Size = new System.Drawing.Size(89, 66);
            this.PopCustBtn.TabIndex = 22;
            this.PopCustBtn.Text = "Popular Customer";
            this.PopCustBtn.UseVisualStyleBackColor = true;
            this.PopCustBtn.Click += new System.EventHandler(this.PopCustBtn_Click);
            // 
            // PopMovBtn
            // 
            this.PopMovBtn.Location = new System.Drawing.Point(407, 15);
            this.PopMovBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopMovBtn.Name = "PopMovBtn";
            this.PopMovBtn.Size = new System.Drawing.Size(89, 66);
            this.PopMovBtn.TabIndex = 23;
            this.PopMovBtn.Text = "Popular Movie";
            this.PopMovBtn.UseVisualStyleBackColor = true;
            this.PopMovBtn.Click += new System.EventHandler(this.PopMovBtn_Click);
            // 
            // AddMovBtn
            // 
            this.AddMovBtn.Location = new System.Drawing.Point(16, 569);
            this.AddMovBtn.Name = "AddMovBtn";
            this.AddMovBtn.Size = new System.Drawing.Size(83, 60);
            this.AddMovBtn.TabIndex = 24;
            this.AddMovBtn.Text = "Add Movie";
            this.AddMovBtn.UseVisualStyleBackColor = true;
            this.AddMovBtn.Click += new System.EventHandler(this.AddMovBtn_Click);
            // 
            // UpdateMovBtn
            // 
            this.UpdateMovBtn.Location = new System.Drawing.Point(107, 569);
            this.UpdateMovBtn.Name = "UpdateMovBtn";
            this.UpdateMovBtn.Size = new System.Drawing.Size(83, 60);
            this.UpdateMovBtn.TabIndex = 25;
            this.UpdateMovBtn.Text = "Update Movie";
            this.UpdateMovBtn.UseVisualStyleBackColor = true;
            this.UpdateMovBtn.Click += new System.EventHandler(this.UpdateMovBtn_Click);
            // 
            // DeleteMovBtn
            // 
            this.DeleteMovBtn.Location = new System.Drawing.Point(212, 569);
            this.DeleteMovBtn.Name = "DeleteMovBtn";
            this.DeleteMovBtn.Size = new System.Drawing.Size(83, 60);
            this.DeleteMovBtn.TabIndex = 26;
            this.DeleteMovBtn.Text = "Delete Movie";
            this.DeleteMovBtn.UseVisualStyleBackColor = true;
            this.DeleteMovBtn.Click += new System.EventHandler(this.DeleteMovBtn_Click);
            // 
            // GenBox
            // 
            this.GenBox.Enabled = false;
            this.GenBox.Location = new System.Drawing.Point(867, 685);
            this.GenBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenBox.Name = "GenBox";
            this.GenBox.Size = new System.Drawing.Size(132, 22);
            this.GenBox.TabIndex = 27;
            // 
            // PlotBox
            // 
            this.PlotBox.Enabled = false;
            this.PlotBox.Location = new System.Drawing.Point(703, 685);
            this.PlotBox.Margin = new System.Windows.Forms.Padding(4);
            this.PlotBox.Name = "PlotBox";
            this.PlotBox.Size = new System.Drawing.Size(132, 22);
            this.PlotBox.TabIndex = 28;
            // 
            // CopBox
            // 
            this.CopBox.Enabled = false;
            this.CopBox.Location = new System.Drawing.Point(547, 685);
            this.CopBox.Margin = new System.Windows.Forms.Padding(4);
            this.CopBox.Name = "CopBox";
            this.CopBox.Size = new System.Drawing.Size(132, 22);
            this.CopBox.TabIndex = 29;
            // 
            // RenCosBox
            // 
            this.RenCosBox.Enabled = false;
            this.RenCosBox.Location = new System.Drawing.Point(362, 685);
            this.RenCosBox.Margin = new System.Windows.Forms.Padding(4);
            this.RenCosBox.Name = "RenCosBox";
            this.RenCosBox.Size = new System.Drawing.Size(132, 22);
            this.RenCosBox.TabIndex = 30;
            this.RenCosBox.Text = " ";
            // 
            // yearBox
            // 
            this.yearBox.Enabled = false;
            this.yearBox.Location = new System.Drawing.Point(867, 619);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(132, 22);
            this.yearBox.TabIndex = 31;
            // 
            // TitBox
            // 
            this.TitBox.Enabled = false;
            this.TitBox.Location = new System.Drawing.Point(703, 619);
            this.TitBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitBox.Name = "TitBox";
            this.TitBox.Size = new System.Drawing.Size(132, 22);
            this.TitBox.TabIndex = 32;
            this.TitBox.TextChanged += new System.EventHandler(this.TitBox_TextChanged);
            // 
            // RatBox
            // 
            this.RatBox.Enabled = false;
            this.RatBox.Location = new System.Drawing.Point(521, 619);
            this.RatBox.Margin = new System.Windows.Forms.Padding(4);
            this.RatBox.Name = "RatBox";
            this.RatBox.Size = new System.Drawing.Size(132, 22);
            this.RatBox.TabIndex = 33;
            this.RatBox.TextChanged += new System.EventHandler(this.RatBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(544, 598);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 17);
            this.RatingLabel.TabIndex = 34;
            this.RatingLabel.Text = "Rating";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(735, 598);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 35;
            this.TitleLabel.Text = "Title";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(907, 598);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(38, 17);
            this.YearLabel.TabIndex = 36;
            this.YearLabel.Text = "Year";
            // 
            // RCLabel
            // 
            this.RCLabel.AutoSize = true;
            this.RCLabel.Location = new System.Drawing.Point(373, 664);
            this.RCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCLabel.Name = "RCLabel";
            this.RCLabel.Size = new System.Drawing.Size(85, 17);
            this.RCLabel.TabIndex = 37;
            this.RCLabel.Text = "Rental_Cost";
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.AutoSize = true;
            this.CopiesLabel.Location = new System.Drawing.Point(560, 664);
            this.CopiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(51, 17);
            this.CopiesLabel.TabIndex = 38;
            this.CopiesLabel.Text = "Copies";
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Location = new System.Drawing.Point(745, 664);
            this.PlotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(32, 17);
            this.PlotLabel.TabIndex = 39;
            this.PlotLabel.Text = "Plot";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(897, 664);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 17);
            this.GenreLabel.TabIndex = 40;
            this.GenreLabel.Text = "Genre";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 764);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.CopiesLabel);
            this.Controls.Add(this.RCLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.RatBox);
            this.Controls.Add(this.TitBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.RenCosBox);
            this.Controls.Add(this.CopBox);
            this.Controls.Add(this.PlotBox);
            this.Controls.Add(this.GenBox);
            this.Controls.Add(this.DeleteMovBtn);
            this.Controls.Add(this.UpdateMovBtn);
            this.Controls.Add(this.AddMovBtn);
            this.Controls.Add(this.PopMovBtn);
            this.Controls.Add(this.PopCustBtn);
            this.Controls.Add(this.LoadRentedMovies);
            this.Controls.Add(this.IssueMovieBtn);
            this.Controls.Add(this.ReturnMovieBtn);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.MovIdBox);
            this.Controls.Add(this.DltCustBtn);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.UpdCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.PhLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AdBox);
            this.Controls.Add(this.LNBox);
            this.Controls.Add(this.FNBox);
            this.Controls.Add(this.LoadMovies);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Video Rental";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button LoadMovies;
        private System.Windows.Forms.TextBox FNBox;
        private System.Windows.Forms.TextBox LNBox;
        private System.Windows.Forms.TextBox AdBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CustomerIdBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox MovIdBox;
        private System.Windows.Forms.Button ReturnMovieBtn;
        private System.Windows.Forms.Button IssueMovieBtn;
        private System.Windows.Forms.Button LoadRentedMovies;
        private System.Windows.Forms.Button PopCustBtn;
        private System.Windows.Forms.Button PopMovBtn;
        private System.Windows.Forms.Button AddMovBtn;
        private System.Windows.Forms.Button UpdateMovBtn;
        private System.Windows.Forms.Button DeleteMovBtn;
        private System.Windows.Forms.TextBox GenBox;
        private System.Windows.Forms.TextBox PlotBox;
        private System.Windows.Forms.TextBox CopBox;
        private System.Windows.Forms.TextBox RenCosBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox TitBox;
        private System.Windows.Forms.TextBox RatBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label RCLabel;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.Label GenreLabel;
    }
}

