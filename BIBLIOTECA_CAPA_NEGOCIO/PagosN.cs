using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BIBLIOTECA_CAPA_DATO;

namespace BIBLIOTECA_CAPA_NEGOCIO
{
    public class PagosN
    {
        PagosD conex = new PagosD();

        public DataSet mostrar_pago()
        {
            return conex.mostrar_pago();
        }

        public DataSet buscar_pago(int id_pago)
        {
            return conex.buscar_pago(id_pago);
        }
        public void insertar_pago(int id_reserva, string metodo_pago, decimal monto, DateTime fecha_pago)
        {
           conex.insertar_pago(id_reserva, metodo_pago, monto, fecha_pago);
        }

        public void eliminar_pago(int id_pago)
        {
            conex.eliminar_pago(id_pago);
        }

        public void actualizar_pago(int id_pago, string metodo_pago, decimal monto, DateTime fecha_pago)
        {
            conex.actualizar_pago(id_pago, metodo_pago, monto, fecha_pago);
        }

    }

   


}
