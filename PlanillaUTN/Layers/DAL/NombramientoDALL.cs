using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.DAL
{
    class NombramientoDALL
    {
        public static void InsertarSP(Nombramiento nom)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarNombramiento";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@IdDocente", nom.IdDocente);
                    comando.Parameters.AddWithValue("@IdJornada", nom.IdJornada);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Utilitarios.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Utilitarios.Log.LogGenericException(ex);
                throw;
            }
        }
        public static void EliminarNombramientoSP(int IdDocente, int IdJornada)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_EliminarNombramiento";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@IdDocente", IdDocente);
                    comando.Parameters.AddWithValue("@IdJornada", IdJornada);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                Utilitarios.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Utilitarios.Log.LogGenericException(ex);
                throw;
            }
        }
        public static Entities.Nombramiento SeleccionarNombramientoIDSP(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarNombramientosporIdDocente";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@IdDocente", id);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);

                    var reader = db.ExecuteReader(comando);
                    Nombramiento Nom = new Nombramiento();

                    while (reader.Read())
                    {
                        Nom.IdDocente = int.Parse(reader["IdDocente"].ToString());
                        Nom.IdJornada = int.Parse(reader["IdJornada"].ToString());
                    }

                    return Nom;
                }
            }
            catch (SqlException sqlEx)
            {
                Utilitarios.Log.LogSQLException(sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                Utilitarios.Log.LogGenericException(ex);
                throw;
            }
        }
    }
    
}
