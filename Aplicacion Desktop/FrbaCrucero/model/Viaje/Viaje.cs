using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero.model
{
    class Viaje
    {
        [System.ComponentModel.DisplayName("Codigo de Viaje")]
        public int viajeId { get; set; }
       [System.ComponentModel.DisplayName("Fecha de Inicio")]
        public Nullable<DateTime> fechaInicio { get; set; }

        public Nullable<DateTime> fechaFin { get; set; }

        [System.ComponentModel.DisplayName("Crucero")]
        public Crucero crucero { get; set; }

        [System.ComponentModel.DisplayName("Recorrido")]
        public Recorrido recorrido { get; set; }

        public Viaje(Crucero crucero, Recorrido recorrido, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
        {
            this.crucero = crucero;
            this.recorrido = recorrido;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public Viaje(int viajeID, int CruceroID, int recorridoId, DateTime FInicio, DateTime FFin)
        {
            // TODO: Complete member initialization
            this.viajeId = viajeID;
            this.crucero = new Crucero (CruceroID);
            this.recorrido = new Recorrido(recorridoId);
            this.fechaInicio = FInicio;
            this.fechaFin = FFin;
        }


        public static List<Viaje> getViajesActvos(DateTime fechaDesde, DateTime FechaHasta, Tramo unTramo)
        {
            List<Viaje> listadoViaje = new List<Viaje>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("ICE_CUBES.SP_BUSCARVIAJES", conexion);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@FDESDE",fechaDesde);
                consulta.Parameters.AddWithValue("@FHASTA", FechaHasta);
                consulta.Parameters.AddWithValue("@PORIGEN",unTramo.origen.idPuerto);
                consulta.Parameters.AddWithValue("@PDESTINO", unTramo.destino.idPuerto);
                conexion.Open();
                SqlDataReader viajes = consulta.ExecuteReader();
                while (viajes.Read())
                {
                    listadoViaje.Add(new Viaje(viajes.GetInt32(0),
                                               viajes.GetInt32(1),
                                               viajes.GetInt32(2),
                                               viajes.GetDateTime(3),
                                               viajes.GetDateTime(4)
                                               )
                                     );
                    //                                reservas.GetDecimal(5),
                    //                                reservas.GetDecimal(6),
                    //                                reservas.GetInt32(7),
                    //                                reservas.GetInt32(8),
                    //                                reservas.GetBoolean(9)
                    //                                ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return listadoViaje;
        }
    }
}
