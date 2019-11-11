using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        public void IngresarPaciente(Entidades.Paciente paciente)
        {
            using (SqlConnection conexion =
                new SqlConnection(ConfigurationManager.
                    ConnectionStrings["DigiSalud"].ConnectionString))
            {
                conexion.Open();
                SqlTransaction tran = conexion.BeginTransaction();
                try
                {
                    SqlCommand comando = new SqlCommand();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;
                    comando.Transaction = tran;
                    comando.CommandText = "IngresarPaciente";
                    var parameter = new SqlParameter("@IdPaciente", SqlDbType.BigInt);
                    parameter.Direction = ParameterDirection.Output;

                    comando.Parameters.Add(parameter);
                    comando.Parameters.Add("@PrimerNombre", SqlDbType.VarChar, 50).Value = paciente.PrimerNombre;
                    comando.Parameters.Add("@SegundoNombre", SqlDbType.VarChar, 50).Value = paciente.SegundoNombre;
                    comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar, 50).Value = paciente.PrimerApellido;
                    comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar, 50).Value = paciente.SegundoApellido;
                    comando.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 50).Value = paciente.NumeroDocumento;
                    comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = paciente.FechaNacimiento;
                    comando.Parameters.Add("@IdSexo", SqlDbType.SmallInt).Value = paciente.Sexo.Id;
                    comando.Parameters.Add("@IdTipoDocumento", SqlDbType.SmallInt).Value = paciente.TipoDocumento.Id;
                    comando.Parameters.Add("@Cotizante", SqlDbType.SmallInt).Value = paciente.Cotizante;
                    comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 50).Value = paciente.Telefono;
                    comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 200).Value = paciente.Direccion;
                    comando.Parameters.Add("@IdCiudad", SqlDbType.Int, 5).Value = paciente.Ciudad.Id;
                    comando.Parameters.Add("@Salario", SqlDbType.Decimal, 20).Value = paciente.Salario;
                    comando.ExecuteNonQuery();

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }

    }
}
