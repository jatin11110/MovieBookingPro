using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBookingPro
{
    public partial class StoreForm : Form
    {
        Model model = new Model();
        string cost;
        public StoreForm()
        {
            InitializeComponent();
        }

        private void st_movie_Click(object sender, EventArgs e)
        {
            model.OptionId = 3;
            DataTable dataTable = new DataTable();
            dataTable = model.Save("select * from tblVideos");
            tableRecord.DataSource = dataTable;
        }

        // show customer to grid view 

        private void st_cust_Click(object sender, EventArgs e)
        {
            model.OptionId = 1;

            DataTable dataTable = new DataTable();
            dataTable = model.Save("select * from tblCustomer");
            tableRecord.DataSource = dataTable;
        }

        private void st_rental_Click(object sender, EventArgs e)
        {
            model.OptionId = 2;

            DataTable dataTable = new DataTable();
            dataTable = model.Save("select * from tblBooking");
            tableRecord.DataSource = dataTable;
        }

        private void pop_movie_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = model.Save("select * from tblVideos");

            int x = 0;
            string Title = "";
            int count = 0;
            while (x < dataTable.Rows.Count)
            {
                DataTable Rental = new DataTable();

                Rental = model.Save("select * from tblBooking where VideoId=" + Convert.ToInt32(dataTable.Rows[x]["VideoId"]) + "");


                if (Rental.Rows.Count > count)
                {

                    Title = dataTable.Rows[x]["title"].ToString();
                    count = Rental.Rows.Count;

                }
                x++;
            }
            MessageBox.Show(Title + "is Best Movie");
        }

        private void add_custo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cust_name.Text != "" && cust_email.Text !="" && cust_city.Text != "")
                {
                    model.Name = cust_name.Text;
                    model.Email = cust_email.Text;
                    model.City = cust_city.Text;
                    
                        string qry = "insert into tblCustomer(Name,Email,City)values('" + model.Name + "','" + model.Email + "','" + model.City + "')";
                        model.DatabaseTransactions(qry);
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_name.Text = "";
                        MessageBox.Show("Customer is Saved Successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void update_custo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cust_id.Text !=  ""  && cust_name.Text.ToString() !=  ""  && cust_email.Text.ToString() !=  ""  && cust_city.Text.ToString() !=  "" )
                {
                    model.CustomerId = Convert.ToInt32(cust_id.Text);
                    model.Name = cust_name.Text;
                    model.Email= cust_email.Text;
                    model.City = cust_city.Text;
                   
                        string qry = "update tblCustomer set Name='" + model.Name + "',Email='" + model.Email+ "',City='" + model.City + "' where CustomerId=" + model.CustomerId + "";
                        model.DatabaseTransactions(qry);
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_name.Text = "";
                        cust_id.Text = "";
                        MessageBox.Show("Customer Updated Successfully");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void delete_cust_Click(object sender, EventArgs e)
        {
            try
            {
                if (cust_id.Text !=  "" )
                {
                    model.CustomerId = Convert.ToInt32(cust_id.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete Customer", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "delete from tblCustomer where CustomerId=" + model.CustomerId + "";
                        model.DatabaseTransactions(qry);
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_name.Text = "";
                        MessageBox.Show("Customer is Deleted Successfully");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Customer");
            }
        }

        private void add_video_Click(object sender, EventArgs e)
        {
            try
            {
                if (movie_name.Text != "" && movie_rates.Text != "" && movie_year.Text != "" && movie_copy.Text != "" && cost != "" && movie_plot.Text !=  "" && movie_genre.Text !=  "" )
                {
                    model.MovieName = movie_name.Text;
                    model.MovieRatting = movie_rates.Text;
                    model.MovieYear = movie_year.Text;
                    model.MovieCopies = movie_copy.Text;
                    model.MovieCost = cost;
                    model.MoviePlot = movie_plot.Text;
                    model.MovieGenre = movie_genre.Text;

                        string qry = "insert into tblVideos(MovieName,MovieRatting,MovieYear,MovieCost,MovieCopies,MoviePlot,MovieGenre)values('" + model.MovieName + "','" + model.MovieRatting + "'," + model.MovieYear + "," + model.MovieCost + "," + model.MovieCopies+ ",'" + model.MoviePlot + "','" + model.MovieGenre + "')";
                        model.DatabaseTransactions(qry);
                        id_movie.Text = "";
                        movie_name.Text = "";
                        movie_rates.Text = "";
                        movie_year.Text = "";
                        movie_copy.Text = "";
                        movie_plot.Text = "";
                        movie_genre.Text = "";
                    MessageBox.Show("Video is Updated Successfully");
                }
                else
                {
                    MessageBox.Show("All fields are required");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void delete_movie_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_movie.Text !=  "")
                {

                    model.VideoId = Convert.ToInt32(id_movie.Text);

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete Video", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "delete from tblVideos where VideoId=" + model.VideoId + "";
                        model.DatabaseTransactions(qry);
                        id_movie.Text = "";
                        movie_name.Text = "";
                        movie_rates.Text = "";
                        movie_year.Text = "";
                        movie_copy.Text = "";
                        movie_plot.Text = "";
                        movie_genre.Text = "";
                        MessageBox.Show("Video is Deleted Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid record");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid record");
            }

        }

        private void update_movie_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_movie.Text !=  ""  && movie_name.Text !=  ""  && movie_rates.Text !=  ""  && movie_year.Text !=  ""  && movie_copy.Text !=  ""  && cost !=  ""  && movie_plot.Text !=  ""  && movie_genre.Text !=  "" )
                {

                    model.VideoId = Convert.ToInt32(id_movie.Text);
                    model.MovieName = movie_name.Text;
                    model.MovieRatting = movie_rates.Text;
                    model.MovieYear = movie_year.Text;
                    model.MovieCopies= movie_copy.Text;
                    model.MovieCost = cost;
                    model.MoviePlot = movie_plot.Text;
                    model.MovieGenre = movie_genre.Text;

                    
                    string qry = "update tblVideos set MovieName='" + model.MovieName + "',MovieRatting='" + model.MovieRatting + "',MovieYear=" + model.MovieYear + ",MovieCost=" + model.MovieCost + ",MovieCopies=" + model.MovieCopies+ ",MoviePlot='" + model.MoviePlot + "',MovieGenre='" + model.MovieGenre + "' where VideoId=" + model.VideoId + "";
                    model.DatabaseTransactions(qry);
                    id_movie.Text = "";
                    movie_name.Text = "";
                    movie_rates.Text = "";
                    movie_year.Text = "";
                    movie_copy.Text = "";
                    movie_plot.Text = "";
                    movie_genre.Text = "";
                    MessageBox.Show("Record is update succesfuly");
                }
                else
                {
                    MessageBox.Show("Please entire boxes required");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please entire boxes required");
            }


        }

        private void issue_rent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cust_id.Text !=  ""  && id_movie.Text !=  "" )
                {
                    model.CustomerId = Convert.ToInt32(cust_id.Text);
                    model.VideoId = Convert.ToInt32(id_movie.Text);
                    model.VideoBook = strtDate.Text;
                    model.VideoReturn = EndDate.Text;

                    string qry = "insert into tblBooking(CustomerId,VideoId,VideoBook,VideoReturn)values(" + model.CustomerId + "," + model.VideoId + ",'" + model.VideoBook + "','" + model.VideoReturn + "')";
                        model.DatabaseTransactions(qry);

                        id_movie.Text = "";
                        movie_name.Text = "";
                        movie_rates.Text = "";
                        movie_year.Text = "";
                        movie_copy.Text = "";
                        movie_plot.Text = "";
                        movie_genre.Text = "";
                        cust_name.Text = "";
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_id.Text = "";
                        MessageBox.Show("Video is Booked ");
                }
                else
                {
                    MessageBox.Show("All fields are required");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("All fields are required");
            }
        }

        // delete rental 

        private void delete_rental_Click(object sender, EventArgs e)
        {
            try
            {
                if (model.BookId > 0)
                {
                   MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the Booking  Video ", "Confirmation Box ", buttons);
                    if (result == DialogResult.Yes)
                    {
                        string qry = "delete from tblBooking where BookId=" + model.BookId + "";
                        model.DatabaseTransactions(qry);

                        id_movie.Text = "";
                        movie_name.Text = "";
                        movie_rates.Text = "";
                        movie_year.Text = "";
                        movie_copy.Text = "";
                        movie_plot.Text = "";
                        movie_genre.Text = "";

                        cust_name.Text = "";
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_id.Text = "";
                        MessageBox.Show("Booked Video is Deleted  Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Record");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Record");
            }


        }

        // return rent booking 

        private void return_rent_Click(object sender, EventArgs e)
        {
            try
            {
                if (model.BookId > 0 && cust_id.Text !=  ""  && id_movie.Text !=  "" )
                {
                    model.CustomerId = Convert.ToInt32(cust_id.Text);
                    model.VideoId = Convert.ToInt32(id_movie.Text);
                    model.VideoBook = strtDate.Text;
                    model.VideoReturn = EndDate.Text;
                    
                        string qry = "update  tblBooking set CustomerId=" + model.CustomerId + ",VideoId=" + model.VideoId + ",VideoBook='" + model.VideoBook + "',VideoReturn='" + model.VideoReturn + "' where BookId=" + model.BookId + "";
                        model.DatabaseTransactions(qry);

                        DateTime nw = DateTime.Now;

                        DateTime old = Convert.ToDateTime(strtDate.Text);

                        string diff = (nw - old).TotalDays.ToString();

                        Double DaysInterval = Math.Round(Convert.ToDouble(diff));

                        DataTable dataTable = new DataTable();
                        dataTable = model.Save("select * from tblVideos where VideoId=" + Convert.ToInt32(id_movie.Text) + "");
                        int cost = Convert.ToInt32(dataTable.Rows[0]["MovieCost"].ToString());

                        id_movie.Text = "";
                        movie_name.Text = "";
                        movie_rates.Text = "";
                        movie_year.Text = "";
                        movie_copy.Text = "";
                        movie_plot.Text = "";
                        movie_genre.Text = "";

                        cust_name.Text = "";
                        cust_city.Text = "";
                        cust_email.Text = "";
                        cust_id.Text = "";
                        MessageBox.Show("Video is Returned and Bill is $" + (DaysInterval * cost));
                }
                else
                {
                    MessageBox.Show("All fields are required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("All fields are required");
            }
        }

        private void tableRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (model.OptionId)
            {
                case 1:
                    
                    cust_id.Text = tableRecord.CurrentRow.Cells[0].Value.ToString();
                    cust_name.Text = tableRecord.CurrentRow.Cells[1].Value.ToString();
                    cust_email.Text = tableRecord.CurrentRow.Cells[2].Value.ToString();
                    cust_city.Text = tableRecord.CurrentRow.Cells[3].Value.ToString();
                    break;

                case 2:
                    model.BookId = Convert.ToInt32(tableRecord.CurrentRow.Cells[0].Value.ToString());
                    cust_id.Text = tableRecord.CurrentRow.Cells[1].Value.ToString();
                    id_movie.Text = tableRecord.CurrentRow.Cells[2].Value.ToString();
                    strtDate.Text = tableRecord.CurrentRow.Cells[3].Value.ToString();
                    break;

                case 3:
                    id_movie.Text = tableRecord.CurrentRow.Cells[0].Value.ToString();
                    movie_name.Text = tableRecord.CurrentRow.Cells[1].Value.ToString();
                    movie_rates.Text = tableRecord.CurrentRow.Cells[2].Value.ToString();
                    movie_year.Text = tableRecord.CurrentRow.Cells[3].Value.ToString();
                    movie_copy.Text = tableRecord.CurrentRow.Cells[5].Value.ToString();
                    movie_plot.Text = tableRecord.CurrentRow.Cells[6].Value.ToString();
                    movie_genre.Text = tableRecord.CurrentRow.Cells[7].Value.ToString();
                    break;
            }
            model.OptionId = 0;
        }

        // show best customers 

        private void bestcus_Click(object sender, EventArgs e)
        {
            
            DataTable dataTablelVideos = new DataTable();

            dataTablelVideos = model.Save("select * from tblCustomer");

            int x = 0;
            int count = 0;
            string Title = "";

            while (x < dataTablelVideos.Rows.Count)
            {
                DataTable dataTablelRental = new DataTable();

                dataTablelRental = model.Save("select * from tblBooking where CustomerId=" + Convert.ToInt32(dataTablelVideos.Rows[x]["CustomerId"]) + "");


                if (dataTablelRental.Rows.Count > count)
                {

                    Title = dataTablelVideos.Rows[x]["MovieName"].ToString();
                    count = dataTablelRental.Rows.Count;
                }
                x++;
            }
            MessageBox.Show(Title + "is Best Customer");
        }

        private void movie_year_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(movie_year.Text.ToString());
                DateTime dateTime = DateTime.Now;

                int currentYear = dateTime.Year;

                if ((currentYear - year) > 5)
                {
                    cost = "2";
                }
                else
                {
                    cost = "5";
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
