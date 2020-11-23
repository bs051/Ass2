using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject
{
    public partial class MainForm : Form
    {
        DB Database = new DB();
        string WhichButtonClicked = "";
        string RMID = "";

        public MainForm()
        {
            InitializeComponent()
                ;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadCustomers();
            WhichButtonClicked = "Customer";
        }

        private void LoadMovies_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMovies();
            WhichButtonClicked = "Movies";
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(FNBox.Text, LNBox.Text, PhoneBox.Text, AdBox.Text);
            LoadBtn_Click(null, null);
        }

        private void UpdCustBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CustomerIdBox.Text, FNBox.Text, LNBox.Text, PhoneBox.Text, AdBox.Text);
            LoadBtn_Click(null, null);
        }


        private void DltCustBtn_Click(object sender, EventArgs e)
        {
            Database.DeleteCustomer(CustomerIdBox.Text);
            LoadBtn_Click(null, null);
        }

        private void IssueMovieBtn_Click(object sender, EventArgs e)
        {
            Database.IssueMovie(MovIdBox.Text, CustomerIdBox.Text);
            LoadRentedMovies_Click(null, null);
        }

        private void LoadRentedMovies_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadRentedMovies();
            WhichButtonClicked = "Rented";
        }

        private void ReturnMovieBtn_Click(object sender, EventArgs e)
        {
            Database.ReturnMovie(RMID);
            LoadRentedMovies_Click(null, null);
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (WhichButtonClicked == "Customer")
            {
                CustomerIdBox.Text = row.Cells[0].Value.ToString();
                FNBox.Text = row.Cells[1].Value.ToString();
                LNBox.Text = row.Cells[2].Value.ToString();
                AdBox.Text = row.Cells[3].Value.ToString();
                PhoneBox.Text = row.Cells[4].Value.ToString();
            }
            else if(WhichButtonClicked == "Movies")
            {
                MovIdBox.Text = row.Cells[0].Value.ToString();
            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }
        }

        private void PopCustBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopularCustomer());
        }

        private void PopMovBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopularMovie());
        }

        private void FNTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMovBtn_Click(object sender, EventArgs e)
        {
            Database.AddMovBtn(RatBox.Text, TitBox.Text, yearBox.Text, RenCosBox.Text, CopBox.Text, PlotBox.Text, GenBox.Text);
            LoadBtn_Click(null, null);
        }

        private void LNBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RatBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateMovBtn_Click(object sender, EventArgs e)
        {
             Database.UpdateMovBtn(RatBox.Text, TitBox.Text, yearBox.Text, RenCosBox.Text, CopBox.Text, PlotBox.Text, GenBox.Text);
            LoadBtn_Click(null, null);
        }

        private void DeleteMovBtn_Click(object sender, EventArgs e)
        {
             Database.DeleteMovBtn(MovIdBox.Text);
            LoadBtn_Click(null, null);
        }

        private void TitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];
            if (row.Cells.Count == 5)
            {
                CustomerIdBox.Text = row.Cells[0].Value.ToString();
                FNBox.Text = row.Cells[1].Value.ToString();
                LNBox.Text = row.Cells[2].Value.ToString();
                AdBox.Text = row.Cells[3].Value.ToString();
                PhoneBox.Text = row.Cells[4].Value.ToString();
            }
            else
                          if (row.Cells.Count == 8)
            {

                MovIdBox.Text = row.Cells[0].Value.ToString();
                RatBox.Text = row.Cells[1].Value.ToString();
                TitBox.Text = row.Cells[2].Value.ToString();
                yearBox.Text = row.Cells[3].Value.ToString();
                RenCosBox.Text = row.Cells[4].Value.ToString();
                CopBox.Text = row.Cells[5].Value.ToString();
                PlotBox.Text = row.Cells[6].Value.ToString();
                GenBox.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
