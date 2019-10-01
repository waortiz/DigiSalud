using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MaestroNegocio
    {
        IMaestroRepositorio repositorio = new MaestroRepositorio();

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return repositorio.ObtenerTiposDocumento();
        }
    }
}
