using PlanillaUTN.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanillaUTN.Layers.DAL
{
    class CategoriaDAL
    {
        public static List<Categoria> SeleccionarCategoriasSP()
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarCategorias";

                    var comando = new SqlCommand(sql);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    List<Categoria> lista = new List<Categoria>();
                    while (reader.Read())
                    {
                        Categoria cat = new Categoria();
                        cat.Id = reader["Id"].ToString();
                        cat.Descripcion = reader["Descripcion"].ToString();
                        cat.SalarioBase = Convert.ToDecimal(reader["SalarioBase"]);
                        cat.CostoAnualidad = Convert.ToDecimal(reader["CostoAnualidad"]);

                        lista.Add(cat);
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
        public static List<String> SeleccionarCategoriasdescripSP()
        {
            try
            {
                List<String> lista = new List<string>();    
                foreach (Categoria item in SeleccionarCategoriasSP())
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
        public static Entities.Categoria SeleccionarCategoriaIDSP(string id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"SP_SeleccionarCategoriaPorId";

                    var comando = new SqlCommand(sql);
                    comando.Parameters.AddWithValue("@Id", id);

                    // IMPORTANTE: antes del Execute se debe indicar al comando que es un SP
                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    db.ExecuteNonQuery(comando);

                    var reader = db.ExecuteReader(comando);
                    Categoria cat = new Categoria();

                    while (reader.Read())
                    {
                        cat.Id = reader["Id"].ToString();
                        cat.Descripcion = reader["Descripcion"].ToString();
                        cat.SalarioBase = Convert.ToDecimal(reader["SalarioBase"]);
                        cat.CostoAnualidad = Convert.ToDecimal(reader["CostoAnualidad"]);
                    }

                    return cat;
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
