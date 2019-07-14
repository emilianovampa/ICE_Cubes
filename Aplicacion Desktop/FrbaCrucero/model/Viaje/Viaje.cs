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
    public class Viaje
    {
        [System.ComponentModel.DisplayName("Codigo de Viaje")]
        public int viajeId { get; set; }
       [System.ComponentModel.DisplayName("Fecha de Inicio")]
        public Nullable<DateTime> fechaInicio { get; set; }

        [System.ComponentModel.DisplayName("Fecha de Fin")]
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

        public static Viaje getViaje(Int32 idViaje)
        {
            Viaje viaje = null;
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {

                conexion.Open();
                SqlCommand consulta2 = new SqlCommand("SELECT VIAJE_ID, VIAJE_CRUCERO_ID, VIAJE_RECORRIDO_ID, VIAJE_FINICIO, VIAJE_FFIN FROM ICE_CUBES.Viaje WHERE VIAJE_ID = @id", conexion);
                consulta2.Parameters.AddWithValue("@id", idViaje);
                SqlDataReader resultados = consulta2.ExecuteReader();

                while (resultados.Read())
                {
                    viaje = new Viaje(resultados.GetInt32(0),
                                                resultados.GetInt32(1),
                                                resultados.GetInt32(2),
                                                resultados.GetDateTime(3),
                                                resultados.GetDateTime(4));
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
            return viaje;
        }



        public static List<Cabina> buscarCabinasDisponibles(Int32 codViaje)
        {
            List<Cabina> cabinas = new List<Cabina>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            SqlCommand consulta = new SqlCommand("ICE_CUBES.SP_buscarCabinasDisponibles", conexion);
            consulta.CommandType = CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@codViaje", codViaje);
            conexion.Open();
            SqlDataReader resultados = consulta.ExecuteReader();
            while (resultados.Read())
                cabinas.Add(new Cabina(resultados.GetInt32(0), resultados.GetInt32(1), resultados.GetDecimal(2), resultados.GetInt32(3), resultados.GetDecimal(4)));
            conexion.Close();
            return cabinas;
        }
    }
}
