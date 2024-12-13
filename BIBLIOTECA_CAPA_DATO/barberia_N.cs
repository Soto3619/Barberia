using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using barberia_datos;

namespace barberia_negocios
{
   public class barberia_N
    {
        barberia_D bar = new barberia_D();

        public DataSet vista()
        {
            return bar.listarServicios();
        }

        public DataSet vista2()
        {
            return bar.listarServicios();
        }
       
        public DataSet buscarF(int c)
        {
            return bar.buscarServicio(c);
        }

        public string realizarReserva(int idReserva, int idServicio, string nombre_cliente, DateTime fecha, TimeSpan hora, int idEstado)
        {
            bool servicioDisponible = VerificarServicioDisponible(idServicio,idEstado);

            if (!servicioDisponible)
            {
                return "No hay suficientes servicios disponibles para la cantidad solicitada.";
            }

            decimal totalFinal = AplicarDescuento(idServicio,idEstado);

            try
            {
             
                bar.realizarReserva(idReserva, idServicio, nombre_cliente, fecha, hora, idEstado);
                return "Reserva realizada con éxito.";
            }
            catch (Exception ex)
            {
                return $"Error al realizar la reserva: {ex.Message}";
            }
        }
        private bool VerificarServicioDisponible(int idServicio, int cantidad)
        {
            DataSet ds = bar.buscarServicio(idServicio);
            int cantidadDisponible = 10; 
            return cantidad <= cantidadDisponible;
        }

        private decimal AplicarDescuento(int idServicio, int idEstado)
        {
            int cantidadReservas = ObtenerCantidadReservas(idServicio);
            if (cantidadReservas > 4)
            {
                return idEstado * 0.9m; // 10% discount
            }
            return idEstado;
        }

      
        private int ObtenerCantidadReservas(int id_servicio)
        {
            DataSet reservas = bar.buscarServicio(id_servicio);
            return reservas.Tables[0].Rows.Count;
        }

       
        public void insertarServicio(int id_servicio, string nombre, string descripcion, decimal precio, int duracion_minutos)
        {
            bar.insertarServicio(id_servicio, nombre, descripcion, precio, duracion_minutos);
        }

 
        public void actualizarServicio(int id_servicio, string nombre, string descripcion, decimal precio, int duracion_minutos)
        {
            bar.actualizarServicio(id_servicio, nombre, descripcion, precio, duracion_minutos);
        }

       
        public void eliminarServicio(int id)
        {
            bar.eliminarServicio(id);
        }
    }
}