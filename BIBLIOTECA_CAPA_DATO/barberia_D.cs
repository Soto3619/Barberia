using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace barberia_datos
{
     public class barberia_D
    {
        String ria = ConfigurationManager.ConnectionStrings["vinculo"].ConnectionString;

        public DataSet listarServicios()
        {
            return SqlHelper.ExecuteDataset(ria, "usp_listar_servicio");
        }

        // Method to insert a new service
        public void insertarServicio(int id, string nombre, string descripcion, decimal precio, int duracion)
        {
            SqlHelper.ExecuteNonQuery(ria, "usp_insertar_servicio", id, nombre, descripcion, precio, duracion);
        }

        // Method to search for a service by ID
        public DataSet buscarServicio(int id)
        {
            return SqlHelper.ExecuteDataset(ria, "usp_buscar_servicio", id);
        }

        // Method to update a service by ID
        public void actualizarServicio(int id, string nombre, string descripcion, decimal precio, int duracion)
        {
            SqlHelper.ExecuteNonQuery(ria, "usp_actualizar_servicio", id, nombre, descripcion, precio, duracion);
        }

        // Method to delete a service by ID
        public void eliminarServicio(int id)
        {
            SqlHelper.ExecuteNonQuery(ria, "usp_eliminar_servicio", id);
        }
        public void realizarReserva(int idReserva, int idServicio,string nombre_cliente, DateTime fecha, TimeSpan hora, int idEstado)
        {
            SqlHelper.ExecuteNonQuery(ria, "usp_RealizarReserva", idReserva, idServicio, nombre_cliente,fecha, hora,idEstado);
        }

        public DataSet wea(int id)
        {
            return SqlHelper.ExecuteDataset(ria, "busqueda", id);

        }

        public DataTable BuscarReservaPorNombre(string nombreCliente)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ria))
                {
                    using (SqlCommand cmd = new SqlCommand("buscar_nom_rese", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nom", nombreCliente);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CAPA_DATOS al buscar reservas por nombre: " + ex.Message);
            }
        }

    }

}


