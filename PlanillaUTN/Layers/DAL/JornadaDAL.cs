using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.DAL
{
    class JornadaDAL
    {
        public static List<Jornada> SeleccionarJornadaPorIdDocSP(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarJornadasPorDocente";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@IdDocente", id);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);

                    var reader = db.ExecuteReader(comando);
                    List<Jornada> lista = new List<Jornada>();
                    while (reader.Read())
                    {
                        Jornada jor = new Jornada();
                        jor.Id = int.Parse(reader["Id"].ToString());
                        jor.Descripcion = reader["Descripcion"].ToString();
                        jor.PorcentajeSalario = int.Parse(reader["Id"].ToString());
                        lista.Add(jor);
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
        public static List<String> SeleccionarJornadasPorIdDoc(int idDocente)
        {
            try
            {
                List<String> lista = new List<string>();
                foreach (Jornada item in SeleccionarJornadaPorIdDocSP(idDocente))
                {
                    lista.Add(item.Descripcion);
                }
                return lista;
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
        public static List<Jornada> SeleccionarTodosSP()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarJornadas";

                    var comando = new SqlCommand(sql);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    List<Jornada> lista = new List<Jornada>();
                    while (reader.Read())
                    {
                        Jornada jor = new Jornada();
                        jor.Id = int.Parse(reader["Id"].ToString());
                        jor.Descripcion = reader["Descripcion"].ToString();
                        jor.PorcentajeSalario = int.Parse(reader["Id"].ToString());
                        lista.Add(jor);
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
        public static List<String> SeleccionarTodosDesc()
        {
            try
            {
                List<String> lista = new List<string>();
                foreach (Jornada item in SeleccionarTodosSP())
                {
                    lista.Add(item.Descripcion);
                }
                return lista;
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
        public static List<Jornada> SeleccionarJornadaPorId(int idDocente)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarJornadasPorDocente";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@IdDocente", idDocente);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);

                    var reader = db.ExecuteReader(comando);

                    List<Jornada> lista = new List<Jornada>();
                    while (reader.Read())
                    {
                        Jornada Jor = new Jornada();
                        Jor.Id = int.Parse(reader["Id"].ToString());
                        Jor.Descripcion = reader["Descripcion"].ToString();
                        Jor.PorcentajeSalario = int.Parse(reader["porcentajeSalario"].ToString());
                        lista.Add(Jor);
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
