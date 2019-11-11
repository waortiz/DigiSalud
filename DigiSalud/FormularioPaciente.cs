using Entidades;
using Negocio;
using System;
using System.Windows.Forms;
using Utilidades;

namespace DigiSalud
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormularioPaciente : Form
    {
         public long IdPaciente;

        /// <summary>
        /// 
        /// </summary>
        public FormularioPaciente()
        {
            //Permite inicializar le formulario
            InitializeComponent();
        }

        /// <summary>
        /// Controlador que permite guardar
        /// </summary>
        /// <param name="sender">Control que genera el evento</param>
        /// <param name="e">Datos del evento</param>
        /// <author>William Ortiz</author>
        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TxtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32)
            {
                if (!(e.KeyChar >= 65 && e.KeyChar <= 90) &&
                    !(e.KeyChar >= 97 && e.KeyChar <= 122))
                {
                    e.Handled = true;
                }
            }
        }

        private void BtnEdad_Click(object sender, EventArgs e)
        {
            if(DtpFechaFacimiento.Value > DateTime.Now)
            {
                ErpMensaje.SetError(DtpFechaFacimiento, 
                    "La fecha de nacimiento debe ser menor a la fecha del sistema");
                return;
            }
            else
            {
                ErpMensaje.SetError(DtpFechaFacimiento, null);
            }
            MessageBox.Show("La edad es: " + 
                Utilidad.ObtenerEdad(DtpFechaFacimiento.Value));
        }

        private void DtpFechaFacimiento_Leave(object sender, EventArgs e)
        {
            if (DtpFechaFacimiento.Value > DateTime.Now)
            {
                ErpMensaje.SetError(DtpFechaFacimiento,
                    "La fecha de nacimiento debe ser menor a la fecha del sistema");
            }
            else
            {
                ErpMensaje.SetError(DtpFechaFacimiento, null);
            }
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32)
            {
                if (e.KeyChar < 48 || e.KeyChar > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtNumeroDocumento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(TxtNumeroDocumento.Text.Length <= 6)
            {
                ErpMensaje.SetError(TxtNumeroDocumento,
              "El número de documento debe tener mas de 6 dígitos");
                e.Cancel = true;
            }
            else
            {
                ErpMensaje.SetError(TxtNumeroDocumento, null);
            }
        }

        private void FormularioPaciente_Load(object sender, EventArgs e)
        {
            ControlMaestro negocio = new ControlMaestro();
            var tiposDocumento = negocio.ObtenerTiposDocumento();
            CboTipoDocumento.DataSource = tiposDocumento;
            CboTipoDocumento.DisplayMember = "Nombre";

            var ciudades = negocio.ObtenerCiudades();
            CboCiudad.DataSource = ciudades;
            CboCiudad.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                var tipoDocumento = CboTipoDocumento.SelectedItem as TipoDocumento;
                var ciudad = CboCiudad.SelectedItem as Ciudad;
                string numeroDocumento = TxtNumeroDocumento.Text;
                string primerNombre = TxtPrimerNombre.Text;
                string segundoNombre = TxtSegundoNombre.Text;
                string primerApellido = TxtPrimerApellido.Text;
                string segundoApellido = TxtSegundoApellido.Text;
                DateTime fechaNacimiento = DtpFechaFacimiento.Value;
                bool esCotizante = ChkCotizante.Checked;
                int sexo = RdbFemenino.Checked ? 1 : (RdbMasculino.Checked ? 2 : 1);
                string telefono = TxtTelefono.Text;
                string direccion = TxtDireccion.Text;
                double salario = double.Parse(
                    TxtSalario.Text.Trim().Replace("$", "").
                    Replace(",", "").
                    Replace(" ", "").
                    Replace(".", ""));

                Paciente paciente = new Paciente()
                {
                   TipoDocumento = tipoDocumento,
                   FechaNacimiento = fechaNacimiento,
                   NumeroDocumento = numeroDocumento,
                   PrimerNombre = primerNombre,
                   SegundoNombre = segundoNombre,
                   PrimerApellido = primerApellido,
                   SegundoApellido = segundoApellido,
                   Cotizante = esCotizante,
                   Sexo = new Sexo() { Id = sexo },
                   Telefono = telefono,
                   Salario = salario,
                   Direccion = direccion,
                   Ciudad = ciudad
                };

                ControlPaciente control = new ControlPaciente();
                control.IngresarPaciente(paciente);

                MessageBox.Show("Paciente guardado exitosamente",
                    "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error al guardar el paciente: " + exc.Message,
                    "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BtnAdicionarAntecedente_Click(object sender, EventArgs e)
        {

        }
    }
}