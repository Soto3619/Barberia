using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BIBLIOTECA_CAPA_DATO;
using Microsoft.ApplicationBlocks.Data;

namespace BIBLIOTECA_CAPA_NEGOCIO
{
    public class CAPA_NEGOCIO
    {
        CAPA_DATO tam = new CAPA_DATO();
        public DataSet mostrarinventario()
        {
            return tam.mostrarinventario();
        }
        public void insertarinventario(int id_inventario, String nombre_producto, String descripcion, int cantidad, decimal precio)
        {
            tam.insertarinventario(id_inventario, nombre_producto, descripcion, cantidad, precio);
        }
        public void actualizarinventario(int id_inventario, String nombre_producto, String descripcion, int cantidad, decimal precio)
        {
            tam.actualizarinventario(id_inventario, nombre_producto, descripcion, cantidad, precio);
        }
        public void eliminarinventario(int id_inventario)
        {
            tam.eliminarinventario(id_inventario);
        }

   

        ////////////////////tabla_reserva
        ///
        CAPA_DATO OLD = new CAPA_DATO();

        public DataSet MOSTRAR_RESERVA()
        {

            return OLD.MOSTRAR_RESERVA(); 
        }

        public void INSERTAR_RESERVA(int id_res, int id_serv, string nom, DateTime fecha, TimeSpan hora, int id_esta)
        {

            OLD.INSERTAR_RESERVA(id_res, id_serv, nom, fecha, hora, id_esta);

        }

        public void ACTUALIZA_RESERVA(int id_res, int id_serv, string nom, string fecha, string hora, int id_esta)
        {

            OLD.ACTUALIZA_RESERVA(id_res, id_serv, nom, fecha, hora, id_esta);
        }
        public void ELIMINAR_RESERVA(int id_res)
        {
            OLD.ELIMINAR_RESERVA(id_res);
        }

        public DataSet BUSCA_RESERVA(int ID_RES)
        {
            return OLD.BUSCA_RESERVA(ID_RES);
        }

        ////////////////////tabla_promociones
        ///


        CAPA_DATO wa = new CAPA_DATO();
        public DataSet ver()
        {
            return wa.muestro();
        }

        public void Elimino(int id)
        {
            wa.Elimino(id);
        }

        public void inserto(int id, int ser, string descrip, decimal descue, string fecha)
        {
            wa.inserto(id, ser, descrip, descue, fecha);
        }

        public void actualiza(int id, int ser, string descrip, decimal descue, string fecha)
        {
            wa.actualiza(id, ser, descrip, descue, fecha);
        }

    }
}
