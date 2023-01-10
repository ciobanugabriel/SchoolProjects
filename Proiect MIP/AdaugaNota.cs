using MySqlConnector;
using Proiect_MIP.Clase;
using Secure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_MIP
{
    public partial class AdaugaNota : Form
    {
        private const string connectionURL = "server=localhost;uid=root; pwd=root;database=catalog";
        private string notaMate;
        private string notaInfo;
        private string notaRomana;
        private string password;
        public AdaugaNota()
        {
            InitializeComponent();
            List<Student> students = getStudents();

            List<Item> items = new List<Item>();

            foreach (Student student in students)
            {
                items.Add(new Item() { Text = student.getName(), Value = student.getId() });
            }

            comboBoxNota.DataSource = items;
            comboBoxNota.DisplayMember = "Text";
            comboBoxNota.ValueMember = "Value";

        }
        public class Item
        {
            public Item() { }

            public int Value { set; get; }
            public string Text { set; get; }
        }
        private List<Student> getStudents()
    
        {
            List<Student> students = new List<Student>();
            MySqlConnection connection;

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * from student", connection);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        students.Add(new Student(mySqlDataReader.GetInt16(0), mySqlDataReader.GetString(1), mySqlDataReader.GetString(2)));
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Conexiunea a esuat " + ex.Message);
            }


            return students;
        }

        private void adaugaNotaButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxNota.SelectedValue);

            notaMate = textBoxMate.Text;
            notaInfo = textBoxInfo.Text;
            notaRomana = textBoxRom.Text;

            MySqlConnection connection;

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT password from student where id=" + id , connection);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
         
                        password = mySqlDataReader.GetString(0);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Conexiunea a esuat " + ex.Message);
            }
            
            
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO nota(mate,info,romana,studentID) values('" +
                      Secure.Make.encrypt(notaMate,password) + "','" + Secure.Make.encrypt(notaInfo,password) + 
                      "','"  + Secure.Make.encrypt(notaRomana, password) + "'," + id + ")", connection);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Conexiunea a esuat " + ex.Message);
            }
            textBoxMate.Text ="";
            textBoxInfo.Text = "";
            textBoxRom.Text = "";

        }
    }
}
