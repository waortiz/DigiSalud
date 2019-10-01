using Entidades;
using System.Collections.Generic;

namespace Repositorio
{
    public interface IMaestroRepositorio
    {
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}