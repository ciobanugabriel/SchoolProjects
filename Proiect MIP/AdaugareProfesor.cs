using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_MIP
{
    public partial class AdaugareProfesor : Form
    {
        private const string connectionURL = "server=localhost;uid=root; pwd=root;database=catalog";
        public AdaugareProfesor()
        {
            InitializeComponent();
        }

        private void profesorButton_Click(object sender, EventArgs e)
        {
            string numeProfesor = profesorInput.Text;
            adaugareProfesor(numeProfesor);
            profesorInput.Text = "";
  
        }
        private static void adaugareProfesor(string name)
        {
            MySqlConnection connection;

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO profesor(name) values('" +
                        name + "')", connection);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Conexiunea a esuat " + ex.Message);
            }
        }
    }
}
