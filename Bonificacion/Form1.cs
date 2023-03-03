namespace Bonificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBonificacion_CheckedChanged(object sender, EventArgs e)
        {
            if(cbBonificacion.Checked)
            {
                udHijos.Enabled = true;
            }
            else
            {
                udHijos.Enabled = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Horas, HorasExtra, Pago, PagoExtra, Hijos, SueldoBruto, Bonificacion, SueldoNeto;
            Horas = Double.Parse(udHoras.Text);
            HorasExtra = Double.Parse(udHorasExtra.Text);
            Pago = Double.Parse(udPago.Text);
            PagoExtra = Double.Parse(udPagoExtra.Text);
            Hijos = Double.Parse(udHijos.Text);

            SueldoBruto = (Horas * Pago) + (HorasExtra * PagoExtra);
            if (cbBonificacion.Checked)
                Bonificacion = 20 * Hijos;
            else
                Bonificacion = 0;
            SueldoNeto = SueldoBruto + Bonificacion;

            txtSueldoBruto.Text = "" + SueldoBruto;
            txtBonificacion.Text = " " + Bonificacion;
            txtSueldoNeto.Text = " " + SueldoNeto;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            udHoras.Text = "00";
            udHorasExtra.Text = "00";
            udPago.Text = "0.00";
            udPagoExtra.Text = "0.00";
            udHijos.Text = "0";
            cbBonificacion.Checked = false;
            txtSueldoBruto.Text = "00";
            txtBonificacion.Text = "00";
            txtSueldoNeto.Text = "00";
        }
    }
}