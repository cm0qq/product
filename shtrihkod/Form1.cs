using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Aspose.Pdf;
using Aspose.Pdf.Operators;
using System.Drawing.Printing;

namespace shtrihkod
{
    public partial class Form1 : Form
    {
        private string article;
        public Form1()
        {
            InitializeComponent();
            LoadProductName();
        }

        private void LoadProductName()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }


        private void RealTimeSearch()
        {
            string searchString = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchString))
            {
                string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Артикул, Название, Стоимость FROM Товары WHERE Название ILIKE @searchString";

                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string productName = reader["Название"].ToString();
                                string artikul = reader["Артикул"].ToString();
                                string count = reader["Стоимость"].ToString();
                                label6.Text = productName;
                                label11.Text = count;
                                linkLabel1.Text = artikul;
                            }
                            else
                            {
                                label6.Text = "Товар не найден";
                                label11.Text = "Товар не найден";
                                linkLabel1.Text = "Товар не найден";
                            }
                        }
                    }
                }
            }
        }
        private void LoadProductName2()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProductName2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProductName();
        }

        private void stMin()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }
        private void stMax()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            switch (selectedOption)
            {
                case "Стоимость минимальная":
                    stMin();
                    break;

                case "Стоимость максимальная":
                    stMax();
                    break;

                case "Всё":
                    LoadProductName();
                    break;
            }
        }

        private List<decimal> prices = new List<decimal>();

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RealTimeSearch();
        }

        private void filObuv()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }
        private void fildr()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1111;Database=product";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 3";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

            string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 4";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string productName = reader["Название"].ToString();
                        label7.Text = productName;
                    }
                    else
                    {
                        label7.Text = "Товар не найден";
                    }
                }
            }
                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }
                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox2.SelectedItem.ToString();
                switch (selectedOption)
                {
                    case "Обувь":
                        filObuv();
                        break;

                    case "Другое":
                    fildr();
                        break;

                case "Все типы":
                    LoadProductName();
                        break;
                }            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            article = linkLabel1.Text;
            vava(article);
        }
        private Bitmap DrawBarcode(string code, int resolution = 20) // resolution - пикселей на миллиметр
        {

            int numberCount = 8;

            float height = 25.93f * resolution;
            float lineHeight = 22.85f * resolution;
            float leftOffset = 3.63f * resolution;
            float rightOffset = 2.31f * resolution;
            float longLineHeight = lineHeight + 1.65f * resolution;
            float fontHeight = 2.75f * resolution;
            float lineToFontOffset = 0.165f * resolution;
            float lineWidthDelta = 0.15f * resolution;
            float lineWidthFull = 1.35f * resolution;
            float lineOffset = 0.2f * resolution;
            float width = leftOffset + rightOffset + 6 * (lineWidthDelta + lineOffset) + numberCount * (lineWidthFull + lineOffset);

            Bitmap bitmap = new Bitmap((int)width, (int)height);
            Graphics g = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", fontHeight, FontStyle.Regular, GraphicsUnit.Pixel);
            StringFormat fontFormat = new StringFormat();
            fontFormat.Alignment = StringAlignment.Center;
            fontFormat.LineAlignment = StringAlignment.Center;
            float x = leftOffset;

            for (int i = 0; i < numberCount; i++)
            {
                int number = Convert.ToInt32(code[i].ToString());
                if (number != 0)
                {
                    g.FillRectangle(Brushes.Black, x, 0, number * lineWidthDelta, lineHeight);
                }
                RectangleF fontRect = new RectangleF(x, lineHeight + lineToFontOffset, lineWidthFull, fontHeight);
                g.DrawString(code[i].ToString(), font, Brushes.Black, fontRect, fontFormat);
                x += lineWidthFull + lineOffset;

                if (i == 0 || i == numberCount / 2 || i == numberCount - 1)
                {
                for (int j = 0; j < 2; j++)
                    {
                    g.FillRectangle(Brushes.Black, x, 0, lineWidthDelta, longLineHeight);
                    x += lineWidthDelta + lineOffset;
                    }
                }
            }
         return bitmap;
        }

        private void vava(string article)
        {
            Bitmap bitmap = DrawBarcode(article);

            using (PrintDocument printDocument = new PrintDocument())
            {
                printDocument.PrintPage += (s, e) =>
                {
                    RectangleF imageRect = new RectangleF(100, 100, 200, 150);
                    e.Graphics.DrawImage(bitmap, imageRect);
                    e.HasMorePages = false;
                };
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            article = linkLabel2.Text;
            vava(article);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            article = linkLabel3.Text;
            vava(article);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            article = linkLabel4.Text;
            vava(article);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            article = linkLabel5.Text;
            vava(article);
        }       

        private void DisplayProduct(string name, string price, string code)
        {
            // Здесь вы можете обновить свои лейблы или другие элементы интерфейса
            label1.Text = name;
            label11.Text = price;
            linkLabel1.Text = code;
        }
    }
}

