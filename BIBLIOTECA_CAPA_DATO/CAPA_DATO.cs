using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace BIBLIOTECA_CAPA_DATO
{
    public class CAPA_DATO
    {
        string enviarSQL = ConfigurationManager.ConnectionStrings["vinculo"].ConnectionString;

        public DataSet mostrarinventario()
        {
            return SqlHelper.ExecuteDataset(enviarSQL, "usp_listar_inventario");
        }

        public void insertarinventario(int id_inventario, String nombre_producto, String descripcion, int cantidad,decimal precio)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_insertar_inventario", id_inventario, nombre_producto, descripcion, cantidad,precio);
        }

        public void actualizarinventario(int id_inventario, String nombre_producto, String descripcion, int cantidad, decimal precio)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_actualizar_inventario", id_inventario, nombre_producto, descripcion, cantidad, precio);
        }

        public void eliminarinventario(int id_inventario)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "usp_eliminar_inventario", id_inventario);
        }

        ///////////////////////////////////////////////////////////////////tabla_reserva
        public DataSet MOSTRAR_RESERVA()
        {

            return SqlHelper.ExecuteDataset(enviarSQL, "sp_mostrar");
        }
      
        public void ACTUALIZA_RESERVA(int id_res, int id_serv, string nom, string fecha, string hora, int id_esta)
        {

            SqlHelper.ExecuteNonQuery(enviarSQL, "sp_actualizar", id_res, id_serv, nom, fecha, hora, id_esta);
        }
        public void ELIMINAR_RESERVA(int id_res)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "sp_elimanar", id_res);
        }

        public DataSet BUSCA_RESERVA(int ID_RES)
        {
            return SqlHelper.ExecuteDataset(enviarSQL, "sp_buscar", ID_RES);
        }

        


        ///////////////////////////////////////////////////////////////////tabla_Promociones

        public DataSet muestro()
        {
            return SqlHelper.ExecuteDataset(enviarSQL, "mostrar");
        }
        public void Elimino(int id)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "borra", id);
        }

        public void inserto(int id, int ser, string descrip, decimal descue, string fecha)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "insertar", id, ser, descrip, descue, fecha);
        }

        public void actualiza(int id, int ser, string descrip, decimal descue, string fecha)
        {
            SqlHelper.ExecuteNonQuery(enviarSQL, "actualizar", id, ser, descrip, descue, fecha);
        }


        public void INSERTAR_RESERVA(int id_res, int id_serv, string nom, DateTime fecha, TimeSpan hora, int id_esta)
        {

            SqlHelper.ExecuteNonQuery(enviarSQL, "sp_insertar", id_res, id_serv, nom, fecha, hora, id_esta);

        }

        
    }
}
