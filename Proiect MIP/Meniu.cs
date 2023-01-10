namespace Proiect_MIP
{
    public partial class Meniu : Form
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugareStudent form1 = new AdaugareStudent();
            form1.ShowDialog();
            
        }

        private void profesorButton_Click(object sender, EventArgs e)
        {
            AdaugareProfesor form2 = new AdaugareProfesor();
            form2.ShowDialog();

        }

        private void notaButton_Click(object sender, EventArgs e)
        {
            AdaugaNota form3 = new AdaugaNota();
            form3.ShowDialog();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            AfiseazaNote form4 = new AfiseazaNote();
            form4.ShowDialog();
        }
    }
}