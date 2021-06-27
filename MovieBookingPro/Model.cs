using System.Data;
using System.Data.SqlClient;

namespace MovieBookingPro
{
    public class Model
    {
            public int CustomerId { get; set; }
            public int OptionId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
            public int VideoId { get; set; }
            public string MovieName { get; set; }
            public string MovieRatting { get; set; }
            public string MovieYear { get; set; }
            public string MovieCopies { get; set; }
            public string MovieCost { get; set; }
            public string MoviePlot { get; set; }
            public string MovieGenre { get; set; }


            public int BookId { get; set; }
            public string VideoBook { get; set; }
            public string VideoReturn { get; set; }


            public SqlConnection conn;

            public string connStr = "Data Source=DESKTOP-TK206IV\\SQLEXPRESS;Initial Catalog=DbMovieBookingPro;Integrated Security=True";
            public SqlCommand cmd;
            public SqlDataReader reader;
            public void DatabaseTransactions(string query)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }


            // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
            public DataTable Save(string qry)
            {
                DataTable tbl = new DataTable();

                conn = new SqlConnection(connStr);

                conn.Open();

                cmd = new SqlCommand(qry, conn);

                reader = cmd.ExecuteReader();

                tbl.Load(reader);

                conn.Close();

                return tbl;
            }
    }
}
