using System;
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
        public int id;
        public List<Tramo> tramos = new List<Tramo> { };
        private Boolean estado = true;

        public Recorrido(int id, List<Tramo> tramos, Boolean estado)
        {
            this.id = id;
            this.tramos = tramos;
            this.estado = estado;
        }

        public void eliminarRecorrido()
        {
            estado = false;
            /* Agregar todo lo que sucede cuando se elimina un recorrido*/
        }

        public List<Tramo> getTramos()
        {
            return tramos;
        }

        public Puerto getOrigen()
        {
            return tramos.First().origen;
        }
        public Puerto getDestino()
        {
            return tramos.Last().destino;
        }

        public Boolean getEstado()
        {
            return estado;
        }

        public void setTramos(List<Tramo> tramos)
        {
            this.tramos = tramos;
        }

        public Boolean pasaPor(Puerto puerto)
        {
            Boolean pasaPorAhi = false;
            foreach(Tramo tramo in tramos){
                pasaPorAhi = pasaPorAhi || tramo.pasaPor(puerto);
            }
            return pasaPorAhi;
        }

        public int guardarRecorrido()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                if (id == 0)
                {
                    SqlCommand consulta = new SqlCommand("SELECT MAX(RECO_ID) FROM ICE_CUBES.RECORRIDO", conexion);
                    conexion.Open();
                    SqlDataReader reco_id_max = consulta.ExecuteReader();
                    id = reco_id_max.GetFieldValue<int>(0) + 1;
                }
                else
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM ICE_CUBES.TRAMOS WHERE RECO_ID = '" + id.ToString() + "'", conexion);
                    delete.ExecuteNonQuery();
                }
                SqlCommand insertReco = new SqlCommand("INSERT INTO ICE_CUBES.RECORRIDO(RECO_ID,RECO_ESTADO) VALUES ('"+ id.ToString() + ", '1');", conexion);
                insertReco.ExecuteNonQuery();
                String insert = "INSERT INTO ICE_CUBES.TRAMOS(TRAMO_RECO_ID, TRAMO_NIVEL, TRAMO_ORIGEN, TRAMO_DESTINO) VALUES ";
                int i = 0;
                foreach(Tramo tramo in tramos)
                {
                    if(i++ == 0)
                    {
                        insert = insert + "( '" ;
                    }
                    else
                    {
                        insert = insert + ", ( '" ;
                    }
                    insert = insert + id.ToString()+ "', '"
                                                + tramo.nivel.ToString() +  "', '"
                                                + tramo.origen.idPuerto.ToString() + "', '"
                                                + tramo.destino.idPuerto.ToString() + "')"; 
                                       
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
            return id;
         }
    }
}
