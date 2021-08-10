using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.DAL
{
    class DocenteDAL
    {
        public static Entities.Docente SeleccionarDocenteIDSP(string id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarDocentePorId";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Id", id);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);

                    var reader = db.ExecuteReader(comando);
                    Docente Doc = new Docente();

                    while (reader.Read())
                    {
                        Doc.Id = int.Parse(reader["Id"].ToString());
                        Doc.Nombre = reader["Nombre"].ToString();
                        Doc.Apellido = reader["Apellido"].ToString();
                        Doc.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                        Doc.Email = reader["Email"].ToString();
                        Doc.IdCategoria = reader["IdCategoria"].ToString();
                    }

                    return Doc;
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

        public static void InsertarSP(Docente doc)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_InsertarDocente";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@id", doc.Id);
                    comando.Parameters.AddWithValue("@nombre", doc.Nombre);
                    comando.Parameters.AddWithValue("@apellido", doc.Apellido);
                    comando.Parameters.AddWithValue("@fechaIngreso", doc.FechaIngreso);
                    comando.Parameters.AddWithValue("@email", doc.Email);
                    comando.Parameters.AddWithValue("@idCategoria", doc.IdCategoria);


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

        public static List<Docente> SeleccionarTodosSP()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarDocentes";

                    var comando = new SqlCommand(sql);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    List<Docente> lista = new List<Docente>();
                    while (reader.Read())
                    {
                        Docente doc = new Docente();

                        doc.Id = int.Parse(reader["Id"].ToString());
                        doc.Nombre = reader["Nombre"].ToString();
                        doc.Apellido = reader["Apellido"].ToString();
                        doc.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                        doc.Email = reader["Email"].ToString();
                        doc.IdCategoria = reader["IdCategoria"].ToString();
                        doc.nombreCategoria = PlanillaUTN.Layers.DAL.CategoriaDAL.SeleccionarCategoriaIDSP(doc.IdCategoria).Descripcion;

                        lista.Add(doc);
                    }

                    return lista;
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
