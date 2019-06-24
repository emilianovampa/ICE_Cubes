using FrbaCrucero.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public class Rol
    {
        public decimal rolId { get; set; }
        public string rolDescripcion { get; set; }
        public Boolean estado { get; set; }
        public List<Funcionalidad> funcionalidades  = new List<Funcionalidad>();
        private object p1;
        private byte p2;
        private string p3;

        public Rol(decimal idRol, Boolean estado, String desc)
        {
            this.rolId = idRol;
            this.rolDescripcion = desc;
            this.estado = estado;

            this.obetenerFuncionalidades(idRol);

        }

        private void obetenerFuncionalidades(decimal idRol)
        {

            //List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand
                  ("SELECT f.FUNCION_ID, f.FUNCION_NOMBRE FROM ICE_CUBES.ROL_FUNCIONALIDAD rf, ICE_CUBES.FUNCIONALIDAD f WHERE rf.ID_ROL = @codRol AND f.FUNCION_ID = rf.ID_FUNCIONALIDAD", conexion);
                consulta.Parameters.AddWithValue("@codRol", idRol);
                conexion.Open();
                SqlDataReader funcResultados = consulta.ExecuteReader();
                while (funcResultados.Read())
                {
                    //funcionalidades.Add(new Funcionalidad(funcResultados.GetInt32(0), funcResultados.GetString(1)));
                    this.funcionalidades.Add(new Funcionalidad(funcResultados.GetDecimal(0), funcResultados.GetString(1)));
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
            //return funcionalidades;
            




        }


    }
}
