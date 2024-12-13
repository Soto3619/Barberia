using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace BIBLIOTECA_CAPA_DATO
{
    public class servicioD
    {
        string enviarSQL = ConfigurationManager.ConnectionStrings["vinculo"].ConnectionString;

        public DataSet mostrarServicio()
        {
            return SqlHelper.ExecuteDataset(enviarSQL, "usp_listar_servicio");
        }

        public void insertarServicio(int id, String nom, String des, Decimal pre, int dur)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_insertar_servicio", id, nom, des, pre, dur);
        }

        public void actualizarServicio(int id, String nom, String des, Decimal pre, int dur)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_actualizar_servicio", id, nom, des, pre, dur);
        }

        public void eliminarServicio(int id)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_eliminar_servicio", id);
        }

        string conex = ConfigurationManager.ConnectionStrings["vinculo"].ConnectionString;
        public DataTable Listar_Servicios()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("usp_listar_servicio", conex);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;

        }

    }
}
