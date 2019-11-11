using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class MaestroRepositorio : IMaestroRepositorio
    {
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            using (SqlConnection conexion =
                new SqlConnection(ConfigurationManager.
                    ConnectionStrings["DigiSalud"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "SELECT Id, Nombre FROM TiposDocumento ORDER by Nombre";

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDocumento.Add(new TipoDocumento() { Id = reader.GetInt32(0), Nombre = reader.GetString(1) });
                    }
                }
            }

            return tiposDocumento;
        }
               
        public List<Ciudad> ObtenerCiudades()
        {
            {
                List<Ciudad> ciudades = new List<Ciudad>();
                using (SqlConnection conexion =
                    new SqlConnection(ConfigurationManager.
                        ConnectionStrings["DigiSalud"].ConnectionString))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT Id, Nombre FROM Ciudades ORDER by Nombre";

                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ciudades.Add(new Ciudad() { Id = reader.GetInt32(0), Nombre = reader.GetString(1) });
                        }
                    }
                }

                return ciudades;
            }
        }
    }
}
