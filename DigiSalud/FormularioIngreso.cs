using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiSalud
{
    public partial class FormularioIngreso : Form
    {
        public FormularioIngreso()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioPrincipal();
            //typeof: Permite obtener la información de 
            //la clase
            var tipo = typeof(FormularioPrincipal);
            
            //Is: Permite determinar si el formulario
            //es de tipo FormularioPrincipal
            if(formulario is FormularioPrincipal)
            {
                FormularioPrincipal form2 =
                    formulario as FormularioPrincipal;
            }

            formulario.Show();
            Hide();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            TxtUsuario.BackColor = Color.LightSkyBlue;
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            TxtUsuario.BackColor = Color.White;
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            TxtContraseña.BackColor = Color.LightSkyBlue;
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            TxtContraseña.BackColor = Color.White;
        }
    }
}
