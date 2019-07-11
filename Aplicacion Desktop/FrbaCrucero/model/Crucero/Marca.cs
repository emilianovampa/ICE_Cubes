using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.model
{
    public class Marca
    {
        [System.ComponentModel.DisplayName("Identificador")]
        public int idMarca { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public String nombre { get; set; }

        public Marca(int idMarca, String nombre)
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
        }
        public static List<Marca> getMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {   
                String select = "SELECT MARCA_ID, MARCA_NOMBRE" 
                              + "FROM ICE_CUBES.MARCA "
                              + " ORDER BY 2";           
                SqlCommand consulta = new SqlCommand(select.ToString(), conexion);
                conexion.Open();
                SqlDataReader marcasSql = consulta.ExecuteReader();
                while (marcasSql.Read())
                {
                    marcas.Add(new Marca(marcasSql.GetFieldValue<int>(0),
                                                    marcasSql.GetString(1)));
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
            return marcas;
        }
    };
}
