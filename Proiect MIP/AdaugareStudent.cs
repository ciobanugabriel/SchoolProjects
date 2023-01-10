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
    public partial class AdaugareStudent : Form
    { private const string connectionURL = "server=localhost;uid=root; pwd=root;database=catalog";
        public AdaugareStudent()
        {
            InitializeComponent();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            string numeStudent = studentNameInput.Text;
            string parolaStudent = studentPasswordInput.Text;
            adaugareStudent(numeStudent, parolaStudent);
            studentPasswordInput.Text = "";
            studentNameInput.Text = "";
        }

        private static void adaugareStudent(string name, string password)
        {
            MySqlConnection connection;

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO student(name,password) values('" + 
                        name + "','" + password + "')", connection);
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
