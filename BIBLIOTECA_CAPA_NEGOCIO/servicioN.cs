using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BIBLIOTECA_CAPA_DATO;
namespace BIBLIOTECA_CAPA_NEGOCIO
{
    public class servicioN
    {
        servicioD servD = new servicioD();
        public DataSet mostrarServicio()
        {
            return servD.mostrarServicio();
        }
        public void insertarServicio(int id, String nom, String des, Decimal pre, int dur)
        {
            servD.insertarServicio(id, nom, des, pre,dur);
        }
        public void actualizarServicio(int id, String nom, String des, Decimal pre, int dur)
        {
            servD.actualizarServicio(id, nom,des, pre, dur);
        }
        public void eliminarServicio(int id)
        {
            servD.eliminarServicio(id);
        }
        servicioD objD = new servicioD  ();

        public DataTable Listar_Servicios()
        {
            return objD.Listar_Servicios();
        }

    }
}
