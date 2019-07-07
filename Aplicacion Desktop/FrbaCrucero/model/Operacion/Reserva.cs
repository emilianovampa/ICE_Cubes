﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.model.Operacion
{
   public class Reserva
    {
        private int operacionID;
        private decimal ReservaId;
        private DateTime reservaFecha;
        private decimal pasajeId;
        private DateTime pasajeFecha;
        private decimal precioPasaje;
        private decimal clienteID;
        private int viajeID;
        private int cabinaId;
        private bool estado;

        public Reserva(int p1, decimal p2, DateTime dateTime1, decimal p3, DateTime dateTime2, decimal p4, decimal p5, int p6, int p7, bool p8)
        {
            // TODO: Complete member initialization
            this.operacionID = p1;
            this.ReservaId = p2;
            this.reservaFecha = dateTime1;
            this.pasajeId = p3;
            this.pasajeFecha = dateTime2;
            this.precioPasaje = p4;
            this.clienteID = p5;
            this.viajeID = p6;
            this.cabinaId = p7;
            this.estado = p8;
        }
        public static List<Reserva> getReservas(string numeroReserva)
        {
            List<Reserva> listadoRerservas = new List<Reserva>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                String select = "SELECT * "
                              + "FROM ICE_CUBES.OPERACION WHERE OPER_ESTADO = 1"
                              + " AND OPER_RESERVA_ID =" + numeroReserva.ToString() 
                              + " ORDER BY 2";

                SqlCommand consulta = new SqlCommand(select.ToString(), conexion);
                conexion.Open();
                SqlDataReader reservas = consulta.ExecuteReader();
                while (reservas.Read())
                {
                    listadoRerservas.Add(new Reserva(reservas.GetInt32(0),
                                                    reservas.GetDecimal(1),
                                                    reservas.GetDateTime(2),
                                                    reservas.GetDecimal(3),
                                                    reservas.GetDateTime(4),
                                                    reservas.GetDecimal(5),
                                                    reservas.GetDecimal(6),
                                                    reservas.GetInt32(7),
                                                    reservas.GetInt32(8),
                                                    reservas.GetBoolean(9)
                                                    ));
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
            return listadoRerservas;
        }
    }
}
