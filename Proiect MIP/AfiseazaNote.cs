using MySqlConnector;
using Proiect_MIP.Clase;
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
    public partial class AfiseazaNote : Form
    {
        private const string connectionURL = "server=localhost;uid=root; pwd=root;database=catalog";
        private string password;
        private Student currentStudent;
        private string notaMate;
        private string notaInfo;
        private string notaRomana;
        public AfiseazaNote()
        {
            InitializeComponent();
            List<Student> students = getStudents();

            List<Item> items = new List<Item>();

            foreach (Student student in students)
            {
                items.Add(new Item() { Text = student.getName(), Value = student.getId() });
            }
            
            comboBoxAfiseaza.DataSource = items;
            comboBoxAfiseaza.DisplayMember = "Text";
            comboBoxAfiseaza.ValueMember = "Value";
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

                if (connection.State == ConnectionState.Open)
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

        private void AfiseazaNote_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBoxAfiseaza.SelectedValue);

            password = inputPassAfiseaza.Text;


            MySqlConnection connection;

            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionURL;
                connection.Open();
         
                if (connection.State == ConnectionState.Open)
                {
                    

                    MySqlCommand cmd = new MySqlCommand("SELECT mate,info,romana from nota where studentID=" + id, connection);
                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    Console.WriteLine("nota mate este: " + notaMate);

                    while (mySqlDataReader.Read())
                    {
                        notaMate = Secure.Make.decrypt( mySqlDataReader.GetString(0), password);
                        notaInfo = Secure.Make.decrypt(mySqlDataReader.GetString(1), password);
                        notaRomana = Secure.Make.decrypt(mySqlDataReader.GetString(2), password);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Conexiunea a esuat " + ex.Message);
            }

            labelInfo.Text = notaInfo;
            labelMate.Text = notaMate;
            labelRomana.Text = notaRomana;


        }
    }
}
