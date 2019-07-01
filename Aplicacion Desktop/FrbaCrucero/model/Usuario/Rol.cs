using FrbaCrucero.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public class Rol
    {
        private decimal rolId;
        private string rolDescripcion; 
        private Boolean estado; 
        private List<Funcionalidad> funcionalidades  = new List<Funcionalidad>();

        // Accessors
        public decimal RolId
        {
            get { return rolId; }
            set { rolId = value; }
        }
        public string RolDescripcion
        {
            get { return rolDescripcion; }
            set { rolDescripcion = value; }
        }
        public Boolean Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public List<Funcionalidad> Funcionalidades
        {
            get { return funcionalidades; }
            set { funcionalidades = value; }
        }

        // Constructores
        public Rol() { }

        public Rol(decimal idRol, Boolean estado, String desc)
        {
            this.RolId = idRol;
            this.RolDescripcion = desc;
            this.Estado = estado;

            this.obetenerFuncionalidadesByRol(idRol);
        }

        public void obtenerFuncionalidades()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM ICE_CUBES.FUNCIONALIDAD", conexion);
                conexion.Open();
                SqlDataReader funcResultados = consulta.ExecuteReader();
                while (funcResultados.Read())
                {
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

        }

        public void darDeAltaRol(string rolDescripcion, decimal idFuncionalidad)
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand cmd = new SqlCommand("ICE_CUBES.SP_INGRESAR_ROL", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter variableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
                variableRetorno.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(variableRetorno);
                cmd.Parameters.Add(new SqlParameter("@nombreRol", rolDescripcion)); 
                cmd.Parameters.Add(new SqlParameter("@idFuncionalidad", idFuncionalidad));
                conexion.Open();
                cmd.ExecuteNonQuery();
                int resultado = (int)cmd.Parameters["@resultado"].Value;
                conexion.Close();
               
                if (resultado != 0)
                {
                    RolId = resultado;
                    RolDescripcion = rolDescripcion;
                    MessageBox.Show("El rol ha sido cargado satisfactoriamente en la base de datos.");
                }
                else 
                {
                    MessageBox.Show("El rol ya cuenta con la funcionalidad seleccionada.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void obetenerFuncionalidadesByRol(decimal idRol)
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
            
        }

    }
}
