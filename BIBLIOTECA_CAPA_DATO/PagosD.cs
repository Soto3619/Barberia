using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.Data;

namespace BIBLIOTECA_CAPA_DATO
{
    public class PagosD
    {
        string conexion = ConfigurationManager.ConnectionStrings["vinculo"].ConnectionString;

        public DataSet mostrar_pago()
        {
            return SqlHelper.ExecuteDataset(conexion, "sp_mostrar_pagos");
        }

        public DataSet buscar_pago(int id_pago)
        {
            return SqlHelper.ExecuteDataset(conexion, "sp_buscar_pago", id_pago);
        }
        public void insertar_pago(int id_reserva, string metodo_pago, decimal monto, DateTime fecha_pago)
        {
            SqlHelper.ExecuteDataset(conexion, "insertar_pacientes",id_reserva,metodo_pago,monto,fecha_pago);
        }

        public void eliminar_pago(int id_pago)
        {
            SqlHelper.ExecuteNonQuery(conexion, "sp_eliminar_pago", id_pago);
        }

        public void actualizar_pago(int id_pago, string metodo_pago, decimal monto, DateTime fecha_pago)
        {
            SqlHelper.ExecuteNonQuery(conexion, "sp_actualizar_pago", id_pago, metodo_pago, monto, fecha_pago);
        }


    }

}
