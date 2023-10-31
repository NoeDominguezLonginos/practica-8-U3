namespace practica_8_U3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);

            if (edad < 12.0) MessageBox.Show(" NIÑO ");
            else
                if (edad < 18.0) MessageBox.Show(" ADOLESCENTE ");
            else
                if (edad < 60.0) MessageBox.Show(" ADULTO ");
            else
                if (edad > 60.0) MessageBox.Show(" ADULTO MAYOR ");

        }
    }
}