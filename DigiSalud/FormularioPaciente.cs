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
            try
            {
                string tipoDocumento = CboTipoDocumento.SelectedItem as string;
                string numeroDocumento = TxtNumeroDocumento.Text;
                string primerNombre = TxtPrimerNombre.Text;
                string segundoNombre = TxtSegundoNombre.Text;
                string primerApellido = TxtPrimerApellido.Text;
                string segundoApellido = TxtSegundoApellido.Text;
                DateTime fechaNacimiento = DtpFechaFacimiento.Value;
                bool esCotizante = ChkCotizante.Checked;
                string sexo = RdbFemenino.Checked ? "F" : (RdbMasculino.Checked ? "M" : "");
                string telefono = TxtTelefono.Text;
                double salario = double.Parse(
                    TxtSalario.Text.Replace("$", "").
                    Replace(",", "").
                    Replace(" ", "").
                    Replace(".", ""));

                string datosIngresados = @"Tipo Documento: " + tipoDocumento + "\n" +
                                          "Numero de Documento: " + numeroDocumento + "\n" +
                                          "Nombre: " + primerNombre + " " + segundoNombre + " " +
                                                       primerApellido + " " + segundoApellido + "\n" +
                                          "Fecha de Nacimiento: " + fechaNacimiento.ToString("dd/MM/yyyy") + "\n" +
                                          "Es cotizante:" + (esCotizante ? "Sí" : "No") + "\n" +
                                          "Sexo: " + sexo + "\n" +
                                          "Teléfono: " + telefono + "\n" +
                                          "Salario: " + salario.ToString("$#,###");
                MessageBox.Show("Paciente guardado: " + datosIngresados,
                    "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error al guardar el paciente: " + exc.Message,
                    "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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
            MaestroNegocio negocio = new MaestroNegocio();
            var tiposDocumento = negocio.ObtenerTiposDocumento();
            CboTipoDocumento.DataSource = tiposDocumento;
            CboTipoDocumento.DisplayMember = "Nombre";
        }
    }
}