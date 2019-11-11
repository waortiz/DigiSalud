using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ControlPaciente
    {
        IRepositorioPaciente repositorio;
        public ControlPaciente()
        {
            repositorio = new RepositorioPaciente();
        }

        public void IngresarPaciente(Paciente Paciente)
        {
            repositorio.IngresarPaciente(Paciente);
        }
    }
}
