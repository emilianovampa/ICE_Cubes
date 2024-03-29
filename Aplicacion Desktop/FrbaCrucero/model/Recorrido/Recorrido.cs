﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FrbaCrucero.model
{
    public class Recorrido
    {
        [System.ComponentModel.DisplayName("Id")]
        public int id { get; set; }
        public List<Tramo> tramos = new List<Tramo> { };
        [System.ComponentModel.DisplayName("Activo")]
        public Boolean estado { get; set; }
        
        [System.ComponentModel.DisplayName("Origen")]
        public String origen
        {
            get {return tramos.First().origen.nombre; }
        }
        [System.ComponentModel.DisplayName("Destino")]
        public String destino
        {
            get { return tramos.Last().destino.nombre; }
        }
        [System.ComponentModel.DisplayName("Precio")]
        public decimal precio
        {
            get { return tramos.Sum<Tramo>(tramo => tramo.precio); }
        }
        [System.ComponentModel.DisplayName("Cantidad de Paradas")]
        public int paradas
        {
            get { return tramos.Count; }
        }        

        public Recorrido(int id, List<Tramo> tramos, Boolean estado)
        {
            this.id = id;
            this.tramos = tramos;
            this.estado = estado;
        }

        public Recorrido(int recorridoId)
        {
            // TODO: Complete member initialization
            this.id = recorridoId;
        }
        
        public int guardarRecorrido()
        {
            if (id == 0)
            {
                id = calcularID();
                if (id != 0)
                {
                    insertarRecorrido();
                    insertarTramos();
                }
                else
                {
                    return id;
                }
            }
            else
            {
                eliminarTramosActuales();
                insertarTramos();
            }

            return id;
        }
        public List<Tramo> getTramos()
        {
            return tramos;
        }
        public void setTramos(List<Tramo> tramos)
        {
            this.tramos = tramos;
        }
        // METODOS PARA SQL>

        public static List<Recorrido> listarRecorridos(string where)
        {
            
            List<Recorrido> recorridos = new List<Recorrido>();
            String select_string = "SELECT r.RECO_ID, r.RECO_ESTADO, t.TRAMO_NIVEL,"
                           + "t.TRAMO_ORIGEN, po.PUERTO_NOMBRE, po.PUERTO_ESTADO,"
                           + "t.TRAMO_DESTINO, pd.PUERTO_NOMBRE, pd.PUERTO_ESTADO," 
                           + "t.TRAMO_PRECIO"
                           + " FROM ice_cubes.RECORRIDO r JOIN ice_cubes.TRAMO t ON r.RECO_ID = t.TRAMO_RECO_ID"
                           + " LEFT JOIN ice_cubes.PUERTO po ON t.TRAMO_ORIGEN = po.PUERTO_ID"
                           + " LEFT JOIN ice_cubes.PUERTO pd ON t.TRAMO_DESTINO = pd.PUERTO_ID"
                           + where 
                           + " ORDER BY 1, 3;";
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                List<Tramo> tramos = new List<Tramo>();
                SqlCommand select = new SqlCommand(select_string, conexion);
                conexion.Open();
                SqlDataReader sql_recorridos = select.ExecuteReader();
                sql_recorridos.Read();
                int id_actual = sql_recorridos.GetFieldValue<int>(0);
                Boolean estado_actual = sql_recorridos.GetBoolean(1);
                do
                {
                    if (id_actual == sql_recorridos.GetFieldValue<int>(0))
                    {
                        tramos.Add(new Tramo(//NIVEL
                                             sql_recorridos.GetFieldValue<int>(2), 
                                             // PUERTO ORIGEN
                                             new Puerto(sql_recorridos.GetFieldValue<int>(3), 
                                                        sql_recorridos.GetString(4),
                                                        sql_recorridos.GetBoolean(5)),
                                            // PUERTO DESTINO
                                             new Puerto(sql_recorridos.GetFieldValue<int>(6),
                                                        sql_recorridos.GetString(7),
                                                        sql_recorridos.GetBoolean(8)),
                                            // PRECIO
                                             sql_recorridos.GetDecimal(9)));
                    }
                    else
                    {
                        recorridos.Add(new Recorrido(id_actual, tramos, estado_actual));
                        tramos = new List<Tramo>();
                        id_actual = sql_recorridos.GetFieldValue<int>(0);
                        estado_actual = sql_recorridos.GetBoolean(1);
                        tramos.Add(new Tramo(//NIVEL
                                             sql_recorridos.GetFieldValue<int>(2), 
                                             // PUERTO ORIGEN
                                             new Puerto(sql_recorridos.GetFieldValue<int>(3), 
                                                        sql_recorridos.GetString(4),
                                                        sql_recorridos.GetBoolean(5)),
                                            // PUERTO DESTINO
                                             new Puerto(sql_recorridos.GetFieldValue<int>(6),
                                                        sql_recorridos.GetString(7),
                                                        sql_recorridos.GetBoolean(8)),
                                            // PRECIO
                                             sql_recorridos.GetDecimal(9)));
                    }
                } while (sql_recorridos.Read());
                recorridos.Add(new Recorrido(id_actual, tramos, estado_actual));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return recorridos;
        }
        public void eliminarRecorrido()
        {
            /* Agregar todo lo que sucede cuando se elimina un recorrido*/

            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                conexion.Open();
                SqlCommand delete = new SqlCommand("UPDATE ICE_CUBES.RECORRIDO SET RECO_ESTADO = '0' WHERE RECO_ID = '" + id.ToString() + "';", conexion);
                delete.ExecuteNonQuery();
                estado = false;
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
        public int calcularID()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT MAX(RECO_ID) AS MAXIMO FROM ICE_CUBES.RECORRIDO", conexion);
                conexion.Open();
                SqlDataReader reco_id_max = consulta.ExecuteReader();
                reco_id_max.Read();
                id = reco_id_max.GetFieldValue<int>(0) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return id;
        }
        public void eliminarTramosActuales()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                conexion.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM ICE_CUBES.TRAMO WHERE TRAMO_RECO_ID = '" + id.ToString() + "'", conexion);
                delete.ExecuteNonQuery();
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
        public void insertarRecorrido()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                conexion.Open();
                SqlCommand insertReco = new SqlCommand("INSERT INTO ICE_CUBES.RECORRIDO(RECO_ID,RECO_ESTADO) VALUES ('" + id.ToString() + "', '1');", conexion);
                insertReco.ExecuteNonQuery();
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
        public void insertarTramos()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                conexion.Open();
                String insert = "INSERT INTO ICE_CUBES.TRAMO(TRAMO_RECO_ID, TRAMO_NIVEL, TRAMO_ORIGEN, TRAMO_DESTINO, TRAMO_PRECIO) VALUES ";
                int i = 0;
                foreach (Tramo tramo in tramos)
                {
                    if (i++ == 0)
                    {
                        insert = insert + "( '";
                    }
                    else
                    {
                        insert = insert + ", ( '";
                    }
                    insert = insert + id.ToString() + "', '"
                                    + tramo.nivel.ToString() + "', '"
                                    + tramo.origen.idPuerto.ToString() + "', '"
                                    + tramo.destino.idPuerto.ToString() + "', '"
                                    + tramo.precio.ToString() + "')";

                }
                SqlCommand insertTramo = new SqlCommand(insert, conexion);
                insertTramo.ExecuteNonQuery();
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

    }
}
