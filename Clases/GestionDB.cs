using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class GestionDB
    {
        private static string cadenaConexion;

        static GestionDB() 
        {
            cadenaConexion = "Server=.;Database=MiDataBase;Trusted_Connection=True";
        }

        #region ELIMINAR

        public static void Eliminar(Utiles selected, int id)
        {
            string query = string.Empty;

            if (selected is Lapiz)
            {
                query = $"DELETE FROM LAPICES WHERE id = @id;";
            }
            else if (selected is Goma)
            {
                query = $"DELETE FROM GOMAS WHERE id = @id;";
            }
            else if (selected is Sacapunta)
            {
                query = $"DELETE FROM SACAPUNTAS WHERE id = @id;";
            }
            else if (selected is Fibron)
            {
                query = $"DELETE FROM FIBRON WHERE id = @id;";
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.CommandText = query;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception) 
            {
                throw;
            }
        }

        #endregion

        #region LECTORES

        public static List<Lapiz> LeerLapices()
        {
            List<Lapiz> datos = new List<Lapiz>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "SELECT * FROM LAPICES";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int precio = reader.GetInt32(2);
                        string color = reader.GetString(3);
                        string trazo = reader.GetString(4);
                        Lapiz lapiz = new Lapiz(marca, precio, color, trazo, id);
                        datos.Add(lapiz);
                    }
                }
                return datos;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static List<Goma> LeerGomas()
        {
            List<Goma> datos = new List<Goma>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "SELECT * FROM GOMAS";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int precio = reader.GetInt32(2);
                        string color = reader.GetString(3);
                        int tamanio = reader.GetInt32(4);
                        Goma gomas = new Goma(marca, precio, color, tamanio, id);
                        datos.Add(gomas);
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Sacapunta> LeerSacapuntas()
        {
            List<Sacapunta> datos = new List<Sacapunta>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "SELECT * FROM SACAPUNTAS";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int precio = reader.GetInt32(2);
                        string color = reader.GetString(3);
                        string material = reader.GetString(4);
                        Sacapunta sacapuntas = new Sacapunta(marca, precio, color, material, id);
                        datos.Add(sacapuntas);
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Fibron> LeerFibrones()
        {
            List<Fibron> datos = new List<Fibron>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "SELECT * FROM FIBRONES";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int precio = reader.GetInt32(2);
                        string color = reader.GetString(3);
                        int cantidadTinta = reader.GetInt32(4);
                        Fibron fibron = new Fibron(marca, precio, color, cantidadTinta, id);
                        datos.Add(fibron);
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region ALTAS
        public static void AltaLapiz(Lapiz lapiz)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "INSERT INTO LAPICES (marca, precio, color, trazo) VALUES (@marca, @precio, @color, @trazo)";

                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@marca", lapiz.Marca);
                    cmd.Parameters.AddWithValue("@precio", lapiz.Precio);
                    cmd.Parameters.AddWithValue("@color", lapiz.Color);
                    cmd.Parameters.AddWithValue("@trazo", lapiz.Trazo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AltaGoma(Goma goma)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "INSERT INTO GOMAS (marca, precio, color, tamanio) VALUES (@marca, @precio, @color, @tamanio)";

                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@marca", goma.Marca);
                    cmd.Parameters.AddWithValue("@precio", goma.Precio);
                    cmd.Parameters.AddWithValue("@color", goma.Color);
                    cmd.Parameters.AddWithValue("@tamanio", goma.Tamanio);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AltaSacapunta(Sacapunta sacapunta)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "INSERT INTO SACAPUNTAS (marca, precio, color, material) VALUES (@marca, @precio, @color, @material)";

                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@marca", sacapunta.Marca);
                    cmd.Parameters.AddWithValue("@precio", sacapunta.Precio);
                    cmd.Parameters.AddWithValue("@color", sacapunta.Color);
                    cmd.Parameters.AddWithValue("@material", sacapunta.Material);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AltaFibron(Fibron fibron)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "INSERT INTO FIBRONES (marca, precio, color, cantidadTinta) VALUES (@marca, @precio, @color, @cantidadTinta)";

                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@marca", fibron.Marca);
                    cmd.Parameters.AddWithValue("@precio", fibron.Precio);
                    cmd.Parameters.AddWithValue("@color", fibron.Color);
                    cmd.Parameters.AddWithValue("@cantidadTinta", fibron.CantidadTinta);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region MODIFICACIONES

        public static void ActualizarLapiz(Lapiz lapiz, int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "UPDATE LAPICES SET marca=@marca, precio=@precio, color=@color, trazo=@trazo WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marca", lapiz.Marca);
                    cmd.Parameters.AddWithValue("@precio", lapiz.Precio);
                    cmd.Parameters.AddWithValue("@color", lapiz.Color);
                    cmd.Parameters.AddWithValue("@trazo", lapiz.Trazo);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarGomas(Goma goma, int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "UPDATE GOMAS SET marca=@marca, precio=@precio, color=@color, tamanio=@tamanio WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marca", goma.Marca);
                    cmd.Parameters.AddWithValue("@precio", goma.Precio);
                    cmd.Parameters.AddWithValue("@color", goma.Color);
                    cmd.Parameters.AddWithValue("@tamanio", goma.Tamanio);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarSacapunta(Sacapunta sacapunta, int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "UPDATE SACAPUNTAS SET marca=@marca, precio=@precio, color=@color, material=@material WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marca", sacapunta.Marca);
                    cmd.Parameters.AddWithValue("@precio", sacapunta.Precio);
                    cmd.Parameters.AddWithValue("@color", sacapunta.Color);
                    cmd.Parameters.AddWithValue("@material", sacapunta.Material);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarFibron(Fibron fibron, int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(GestionDB.cadenaConexion))
                {
                    string query = "UPDATE FIBRONES SET marca=@marca, precio=@precio, color=@color, cantidadTinta=@cantidadTinta WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marca", fibron.Marca);
                    cmd.Parameters.AddWithValue("@precio", fibron.Precio);
                    cmd.Parameters.AddWithValue("@color", fibron.Color);
                    cmd.Parameters.AddWithValue("@cantidadTinta", fibron.CantidadTinta);
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
