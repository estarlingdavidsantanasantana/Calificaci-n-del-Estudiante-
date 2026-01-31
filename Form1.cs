namespace primera_tarea_del_año
{
    public partial class Form1 : Form
    {
        private int extraordinario;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNota1.Text);
            double n2 = double.Parse(txtNota2.Text);
            double n3 = double.Parse(txtNota3.Text);
            double n4 = double.Parse(txtNota4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;
            txtPromedio.Text = promedio.ToString("0.00");

            if (promedio > 69)
            {
                txtResultado.Text = "APROBADO";
                txtCompletivo.Enabled = false;
            }

            else
            {
                txtCompletivo.Enabled = true;
            }

            double notaCompletivo = double.Parse(txtCompletivo.Text);

            double notaFinalCompletivo = (promedio * 0.50) + (notaCompletivo * 0.50);


            if (notaFinalCompletivo > 69)
            {
                txtResultado.Text = "COMPLETIVO";
            }

            else
            {
                double extraordinario = (promedio * 0.30) + (notaCompletivo * 0.70);

            }


            if (extraordinario > 69)
            {
                txtResultado.Text = "EXTRAORDINARIO";
            }
            else
            {
                txtResultado.Text = "REPROBADO";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
            txtCompletivo.Clear();
            txtResultado.Clear();

            txtCompletivo.Enabled = false;

        }
    }

}



