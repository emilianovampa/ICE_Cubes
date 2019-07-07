using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.model.Operacion;
using System.ComponentModel;

namespace FrbaCrucero.PagoReserva
{
    public class BusquedaReservaCtrl
    {
        private BusquedaReservaVista pagoReservaVista;

        public BusquedaReservaCtrl(BusquedaReservaVista BusquedaReserva)
        {
            // TODO: Complete member initialization
            this.pagoReservaVista = BusquedaReserva;
            this.limpiarReservas();
        }

        private void limpiarReservas()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("ICES_CUBES.eliminarReservasVencidas", conexion);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@hoy", Program.ObtenerFechaActual());
                conexion.Open();
                consulta.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public BindingSource getReserva(string numeroReserva)
        {
            BindingList<Reserva> Reservas = new BindingList<Reserva>(Reserva.getReservas(numeroReserva));
            return new BindingSource(Reservas, null);
        }
    }
}
