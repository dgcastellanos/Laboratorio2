namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        //Invocando las clases y creando un objeto
        Empleado miEmpleado = new Empleado();
        Nomina miNomina = new Nomina();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            decimal AsignacionDia;

            if (!Decimal.TryParse(txtSalarioDiario.Text, out AsignacionDia))
            {
                errorProvider1.SetError(txtSalarioDiario, "Debe ingresar un número");
                txtSalarioDiario.Focus();
                return;
            }
            errorProvider1.SetError(txtSalarioDiario, "");

            miEmpleado.Nombre        = txtNombre.Text;
            miEmpleado.Identificador = txtID.Text;
            miEmpleado.AsignacionDia = Convert.ToDecimal(txtDiasLaborados.Text);
            miNomina.DiasLaborados   = Convert.ToInt32(txtDiasLaborados.Text);

            MessageBox.Show("Registro almacenado correctamente");
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtSalarioDevengado.Text = miNomina.CalculoNomina(Convert.ToInt32(miNomina.DiasLaborados),
                Convert.ToDecimal(miEmpleado.AsignacionDia)).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtID.Clear();
            txtSalarioDevengado.Clear();
            txtSalarioDiario.Clear();
            txtDiasLaborados.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}