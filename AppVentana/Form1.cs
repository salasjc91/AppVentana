namespace AppVentana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txNombre.Text.Trim();
            string apellido = txApellido.Text.Trim();// TRIM quita los espacios adelante y atras
            if (string.IsNullOrEmpty(nombre))
            {
                lbResultado.Visible = false;
                MessageBox.Show("Debes de digitar un nombre");
                return;
            }
            if (string.IsNullOrEmpty(apellido))
            {
                lbResultado.Visible = false;
                MessageBox.Show("Debes de digitar un apellido");
                return;

            }

            string saludo = "Hola " + nombre + ",soy su programa en C#";
            if (checkIncluirApellido.Checked)
                saludo = "Hola " + nombre + " " + apellido + ",soy su programa en C#";

            lbResultado.Text = saludo;
            lbResultado.Visible = true;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btSaludar.Visible = !checkBox1.Checked;
        }
    }
}
