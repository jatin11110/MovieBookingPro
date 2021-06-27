
namespace MovieBookingPro
{
    partial class StoreForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.strtDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.return_rent = new System.Windows.Forms.Button();
            this.delete_rental = new System.Windows.Forms.Button();
            this.issue_rent = new System.Windows.Forms.Button();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.id_movie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.update_movie = new System.Windows.Forms.Button();
            this.delete_movie = new System.Windows.Forms.Button();
            this.add_video = new System.Windows.Forms.Button();
            this.movie_genre = new System.Windows.Forms.TextBox();
            this.movie_plot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.movie_copy = new System.Windows.Forms.TextBox();
            this.movie_year = new System.Windows.Forms.TextBox();
            this.movie_rates = new System.Windows.Forms.TextBox();
            this.movie_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_custo = new System.Windows.Forms.Button();
            this.delete_cust = new System.Windows.Forms.Button();
            this.cust_city = new System.Windows.Forms.TextBox();
            this.add_custo = new System.Windows.Forms.Button();
            this.cust_email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableRecord = new System.Windows.Forms.DataGridView();
            this.st_rental = new System.Windows.Forms.Button();
            this.st_cust = new System.Windows.Forms.Button();
            this.st_movie = new System.Windows.Forms.Button();
            this.bestcus = new System.Windows.Forms.Button();
            this.pop_movie = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EndDate);
            this.groupBox3.Controls.Add(this.strtDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.return_rent);
            this.groupBox3.Controls.Add(this.delete_rental);
            this.groupBox3.Controls.Add(this.issue_rent);
            this.groupBox3.Controls.Add(this.cust_id);
            this.groupBox3.Controls.Add(this.id_movie);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(929, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 322);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stored Rentals";
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(133, 152);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(132, 20);
            this.EndDate.TabIndex = 18;
            // 
            // strtDate
            // 
            this.strtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.strtDate.Location = new System.Drawing.Point(133, 112);
            this.strtDate.Name = "strtDate";
            this.strtDate.Size = new System.Drawing.Size(132, 20);
            this.strtDate.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Date of Return";
            // 
            // return_rent
            // 
            this.return_rent.BackColor = System.Drawing.Color.Maroon;
            this.return_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_rent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_rent.Location = new System.Drawing.Point(133, 201);
            this.return_rent.Name = "return_rent";
            this.return_rent.Size = new System.Drawing.Size(103, 32);
            this.return_rent.TabIndex = 16;
            this.return_rent.Text = "Return Movie";
            this.return_rent.UseVisualStyleBackColor = false;
            this.return_rent.Click += new System.EventHandler(this.return_rent_Click);
            // 
            // delete_rental
            // 
            this.delete_rental.BackColor = System.Drawing.Color.Maroon;
            this.delete_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_rental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_rental.Location = new System.Drawing.Point(66, 253);
            this.delete_rental.Name = "delete_rental";
            this.delete_rental.Size = new System.Drawing.Size(106, 32);
            this.delete_rental.TabIndex = 15;
            this.delete_rental.Text = "Delete  Movie";
            this.delete_rental.UseVisualStyleBackColor = false;
            this.delete_rental.Click += new System.EventHandler(this.delete_rental_Click);
            // 
            // issue_rent
            // 
            this.issue_rent.BackColor = System.Drawing.Color.Maroon;
            this.issue_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_rent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.issue_rent.Location = new System.Drawing.Point(28, 201);
            this.issue_rent.Name = "issue_rent";
            this.issue_rent.Size = new System.Drawing.Size(93, 32);
            this.issue_rent.TabIndex = 14;
            this.issue_rent.Text = "Issue Movie";
            this.issue_rent.UseVisualStyleBackColor = false;
            this.issue_rent.Click += new System.EventHandler(this.issue_rent_Click);
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(133, 73);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(132, 22);
            this.cust_id.TabIndex = 11;
            // 
            // id_movie
            // 
            this.id_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_movie.Location = new System.Drawing.Point(133, 38);
            this.id_movie.Name = "id_movie";
            this.id_movie.Size = new System.Drawing.Size(132, 22);
            this.id_movie.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Date of Issue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "P ID Customer";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "P ID Movie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // update_movie
            // 
            this.update_movie.BackColor = System.Drawing.Color.White;
            this.update_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_movie.ForeColor = System.Drawing.Color.Maroon;
            this.update_movie.Location = new System.Drawing.Point(409, 103);
            this.update_movie.Name = "update_movie";
            this.update_movie.Size = new System.Drawing.Size(103, 32);
            this.update_movie.TabIndex = 13;
            this.update_movie.Text = "Update  Data";
            this.update_movie.UseVisualStyleBackColor = false;
            this.update_movie.Click += new System.EventHandler(this.update_movie_Click);
            // 
            // delete_movie
            // 
            this.delete_movie.BackColor = System.Drawing.Color.White;
            this.delete_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_movie.ForeColor = System.Drawing.Color.Maroon;
            this.delete_movie.Location = new System.Drawing.Point(527, 103);
            this.delete_movie.Name = "delete_movie";
            this.delete_movie.Size = new System.Drawing.Size(106, 32);
            this.delete_movie.TabIndex = 12;
            this.delete_movie.Text = "Delete  Data";
            this.delete_movie.UseVisualStyleBackColor = false;
            this.delete_movie.Click += new System.EventHandler(this.delete_movie_Click);
            // 
            // add_video
            // 
            this.add_video.BackColor = System.Drawing.Color.White;
            this.add_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_video.ForeColor = System.Drawing.Color.Maroon;
            this.add_video.Location = new System.Drawing.Point(315, 103);
            this.add_video.Name = "add_video";
            this.add_video.Size = new System.Drawing.Size(78, 32);
            this.add_video.TabIndex = 7;
            this.add_video.Text = "Add Data";
            this.add_video.UseVisualStyleBackColor = false;
            this.add_video.Click += new System.EventHandler(this.add_video_Click);
            // 
            // movie_genre
            // 
            this.movie_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_genre.Location = new System.Drawing.Point(438, 64);
            this.movie_genre.Name = "movie_genre";
            this.movie_genre.Size = new System.Drawing.Size(148, 22);
            this.movie_genre.TabIndex = 11;
            // 
            // movie_plot
            // 
            this.movie_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_plot.Location = new System.Drawing.Point(438, 29);
            this.movie_plot.Name = "movie_plot";
            this.movie_plot.Size = new System.Drawing.Size(148, 22);
            this.movie_plot.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Plot";
            // 
            // movie_copy
            // 
            this.movie_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_copy.Location = new System.Drawing.Point(142, 140);
            this.movie_copy.Name = "movie_copy";
            this.movie_copy.Size = new System.Drawing.Size(148, 22);
            this.movie_copy.TabIndex = 7;
            // 
            // movie_year
            // 
            this.movie_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_year.Location = new System.Drawing.Point(142, 103);
            this.movie_year.Name = "movie_year";
            this.movie_year.Size = new System.Drawing.Size(148, 22);
            this.movie_year.TabIndex = 6;
            this.movie_year.TextChanged += new System.EventHandler(this.movie_year_TextChanged_1);
            // 
            // movie_rates
            // 
            this.movie_rates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_rates.Location = new System.Drawing.Point(142, 64);
            this.movie_rates.Name = "movie_rates";
            this.movie_rates.Size = new System.Drawing.Size(148, 22);
            this.movie_rates.TabIndex = 5;
            // 
            // movie_name
            // 
            this.movie_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.Location = new System.Drawing.Point(142, 29);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(148, 22);
            this.movie_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top Ratting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // update_custo
            // 
            this.update_custo.BackColor = System.Drawing.Color.Maroon;
            this.update_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_custo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_custo.Location = new System.Drawing.Point(133, 165);
            this.update_custo.Name = "update_custo";
            this.update_custo.Size = new System.Drawing.Size(103, 32);
            this.update_custo.TabIndex = 16;
            this.update_custo.Text = "Update  Data";
            this.update_custo.UseVisualStyleBackColor = false;
            this.update_custo.Click += new System.EventHandler(this.update_custo_Click);
            // 
            // delete_cust
            // 
            this.delete_cust.BackColor = System.Drawing.Color.Maroon;
            this.delete_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_cust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_cust.Location = new System.Drawing.Point(62, 214);
            this.delete_cust.Name = "delete_cust";
            this.delete_cust.Size = new System.Drawing.Size(106, 32);
            this.delete_cust.TabIndex = 15;
            this.delete_cust.Text = "Delete  Data";
            this.delete_cust.UseVisualStyleBackColor = false;
            this.delete_cust.Click += new System.EventHandler(this.delete_cust_Click);
            // 
            // cust_city
            // 
            this.cust_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_city.Location = new System.Drawing.Point(133, 112);
            this.cust_city.Name = "cust_city";
            this.cust_city.Size = new System.Drawing.Size(132, 22);
            this.cust_city.TabIndex = 12;
            // 
            // add_custo
            // 
            this.add_custo.BackColor = System.Drawing.Color.Maroon;
            this.add_custo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_custo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_custo.Location = new System.Drawing.Point(21, 165);
            this.add_custo.Name = "add_custo";
            this.add_custo.Size = new System.Drawing.Size(78, 32);
            this.add_custo.TabIndex = 14;
            this.add_custo.Text = "Add Data";
            this.add_custo.UseVisualStyleBackColor = false;
            this.add_custo.Click += new System.EventHandler(this.add_custo_Click);
            // 
            // cust_email
            // 
            this.cust_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_email.Location = new System.Drawing.Point(133, 73);
            this.cust_email.Name = "cust_email";
            this.cust_email.Size = new System.Drawing.Size(132, 22);
            this.cust_email.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.update_custo);
            this.groupBox2.Controls.Add(this.delete_cust);
            this.groupBox2.Controls.Add(this.cust_city);
            this.groupBox2.Controls.Add(this.add_custo);
            this.groupBox2.Controls.Add(this.cust_email);
            this.groupBox2.Controls.Add(this.cust_name);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(652, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 322);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stored Customer";
            // 
            // cust_name
            // 
            this.cust_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name.Location = new System.Drawing.Point(133, 38);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(132, 22);
            this.cust_name.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_movie);
            this.groupBox1.Controls.Add(this.delete_movie);
            this.groupBox1.Controls.Add(this.add_video);
            this.groupBox1.Controls.Add(this.movie_genre);
            this.groupBox1.Controls.Add(this.movie_plot);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.movie_copy);
            this.groupBox1.Controls.Add(this.movie_year);
            this.groupBox1.Controls.Add(this.movie_rates);
            this.groupBox1.Controls.Add(this.movie_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(331, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 185);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stored Video ";
            // 
            // tableRecord
            // 
            this.tableRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRecord.Location = new System.Drawing.Point(30, 217);
            this.tableRecord.Name = "tableRecord";
            this.tableRecord.Size = new System.Drawing.Size(616, 322);
            this.tableRecord.TabIndex = 23;
            this.tableRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableRecord_CellContentClick);
            // 
            // st_rental
            // 
            this.st_rental.BackColor = System.Drawing.Color.White;
            this.st_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_rental.ForeColor = System.Drawing.Color.DarkRed;
            this.st_rental.Location = new System.Drawing.Point(67, 146);
            this.st_rental.Name = "st_rental";
            this.st_rental.Size = new System.Drawing.Size(163, 40);
            this.st_rental.TabIndex = 22;
            this.st_rental.Text = "Stored Rental Data";
            this.st_rental.UseVisualStyleBackColor = false;
            this.st_rental.Click += new System.EventHandler(this.st_rental_Click);
            // 
            // st_cust
            // 
            this.st_cust.BackColor = System.Drawing.Color.White;
            this.st_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_cust.ForeColor = System.Drawing.Color.DarkRed;
            this.st_cust.Location = new System.Drawing.Point(144, 90);
            this.st_cust.Name = "st_cust";
            this.st_cust.Size = new System.Drawing.Size(130, 40);
            this.st_cust.TabIndex = 21;
            this.st_cust.Text = "Stored Customers";
            this.st_cust.UseVisualStyleBackColor = false;
            this.st_cust.Click += new System.EventHandler(this.st_cust_Click);
            // 
            // st_movie
            // 
            this.st_movie.BackColor = System.Drawing.Color.White;
            this.st_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_movie.ForeColor = System.Drawing.Color.DarkRed;
            this.st_movie.Location = new System.Drawing.Point(20, 90);
            this.st_movie.Name = "st_movie";
            this.st_movie.Size = new System.Drawing.Size(118, 40);
            this.st_movie.TabIndex = 20;
            this.st_movie.Text = "Stored Movie";
            this.st_movie.UseVisualStyleBackColor = false;
            this.st_movie.Click += new System.EventHandler(this.st_movie_Click);
            // 
            // bestcus
            // 
            this.bestcus.BackColor = System.Drawing.Color.White;
            this.bestcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestcus.ForeColor = System.Drawing.Color.DarkRed;
            this.bestcus.Location = new System.Drawing.Point(144, 26);
            this.bestcus.Name = "bestcus";
            this.bestcus.Size = new System.Drawing.Size(118, 40);
            this.bestcus.TabIndex = 19;
            this.bestcus.Text = "Best Customer";
            this.bestcus.UseVisualStyleBackColor = false;
            this.bestcus.Click += new System.EventHandler(this.bestcus_Click);
            // 
            // pop_movie
            // 
            this.pop_movie.BackColor = System.Drawing.Color.White;
            this.pop_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pop_movie.ForeColor = System.Drawing.Color.DarkRed;
            this.pop_movie.Location = new System.Drawing.Point(20, 26);
            this.pop_movie.Name = "pop_movie";
            this.pop_movie.Size = new System.Drawing.Size(118, 40);
            this.pop_movie.TabIndex = 18;
            this.pop_movie.Text = "Popular Movie";
            this.pop_movie.UseVisualStyleBackColor = false;
            this.pop_movie.Click += new System.EventHandler(this.pop_movie_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1215, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableRecord);
            this.Controls.Add(this.st_rental);
            this.Controls.Add(this.st_cust);
            this.Controls.Add(this.st_movie);
            this.Controls.Add(this.bestcus);
            this.Controls.Add(this.pop_movie);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker strtDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button return_rent;
        private System.Windows.Forms.Button delete_rental;
        private System.Windows.Forms.Button issue_rent;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.TextBox id_movie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update_movie;
        private System.Windows.Forms.Button delete_movie;
        private System.Windows.Forms.Button add_video;
        private System.Windows.Forms.TextBox movie_genre;
        private System.Windows.Forms.TextBox movie_plot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox movie_copy;
        private System.Windows.Forms.TextBox movie_year;
        private System.Windows.Forms.TextBox movie_rates;
        private System.Windows.Forms.TextBox movie_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_custo;
        private System.Windows.Forms.Button delete_cust;
        private System.Windows.Forms.TextBox cust_city;
        private System.Windows.Forms.Button add_custo;
        private System.Windows.Forms.TextBox cust_email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tableRecord;
        private System.Windows.Forms.Button st_rental;
        private System.Windows.Forms.Button st_cust;
        private System.Windows.Forms.Button st_movie;
        private System.Windows.Forms.Button bestcus;
        private System.Windows.Forms.Button pop_movie;
    }
}