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
        private bool estado; 
        private List<Funcionalidad> funcionalidades  = new List<Funcionalidad>();
        private TextBox textBox;
        private List<Funcionalidad> list;

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
        public bool Estado
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

        public Rol(string rolDescripcion, bool estado, List<Funcionalidad> funcionalidades)
        {
            RolDescripcion = rolDescripcion;
            Estado = estado;
            Funcionalidades = funcionalidades;
        }

        public Rol(decimal idRol, bool estado, String desc)
        {
            this.RolId = idRol;
            this.RolDescripcion = desc;
            this.Estado = estado;

            this.obetenerFuncionalidadesByRol(idRol);
        }

        public Rol(decimal rolId, string rolDescripcion, bool estado, List<Funcionalidad> funcionalidades)
        {
            RolId = rolId;
            RolDescripcion = RolDescripcion;
            Estado = estado;
            Funcionalidades = funcionalidades;
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
                    Funcionalidades.Add(new Funcionalidad(funcResultados.GetDecimal(0), funcResultados.GetString(1)));
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

        private List<Funcionalidad> traerFuncionalidadesByRol(decimal idRol)
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT f.FUNCION_ID, f.FUNCION_NOMBRE FROM ICE_CUBES.FUNCIONALIDAD f, ICE_CUBES.ROL_FUNCIONALIDAD rf WHERE rf.ID_ROL = @idRol AND f.FUNCION_ID = rf.ID_FUNCIONALIDAD", conexion);
                consulta.Parameters.AddWithValue("@idRol", idRol);
                conexion.Open();
                SqlDataReader funcResultados = consulta.ExecuteReader();
                while (funcResultados.Read())
                {
                    funcionalidades.Add(new Funcionalidad(funcResultados.GetDecimal(0), funcResultados.GetString(1)));
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
            return funcionalidades;
        }

        public List<Rol> traerRoles()
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            List<Rol> roles = new List<Rol>();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ICE_CUBES.ROL", conexion);
                conexion.Open();
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    roles.Add(new Rol(result.GetDecimal(0), result.GetString(1), result.GetBoolean(2), this.traerFuncionalidadesByRol(result.GetDecimal(0))));
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
            return roles;
        }

        public List<Funcionalidad> traerFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT * FROM ICE_CUBES.FUNCIONALIDAD;", conexion);
                conexion.Open();
                SqlDataReader funcResultados = consulta.ExecuteReader();
                while (funcResultados.Read())
                {
                    funcionalidades.Add(new Funcionalidad(funcResultados.GetDecimal(0), funcResultados.GetString(1)));
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
            return funcionalidades;
        }

        public void eliminarRol(Rol unRol) 
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();
            SqlCommand borrarFuncionalidades = new SqlCommand("DELETE FROM ICE_CUBES.ROL_FUNCIONALIDAD WHERE ID_ROL = @idRol", conexion, transaction);
            borrarFuncionalidades.Parameters.AddWithValue("@idRol", unRol.RolId);
            try
            {
                borrarFuncionalidades.ExecuteNonQuery();
                SqlCommand comando = new SqlCommand("UPDATE ICE_CUBES.ROL SET ROL_ESTADO = 0 WHERE ROL_ID = @idRol", conexion, transaction);
                comando.Parameters.AddWithValue("@idRol", unRol.RolId);
                comando.ExecuteNonQuery();
                transaction.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                conexion.Close();
                throw ex;
            }
        }

        public void actualizarRol(Rol nuevoRol, Rol viejoRol)
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();
            SqlCommand comando2 = new SqlCommand("", conexion, transaction);
            SqlCommand borrarFuncionalidades = new SqlCommand("DELETE FROM ICE_CUBES.ROL_FUNCIONALIDAD WHERE ID_ROL = @idRol", conexion, transaction);
            borrarFuncionalidades.Parameters.AddWithValue("@idRol", viejoRol.RolId);
            try
            {
                borrarFuncionalidades.ExecuteNonQuery();
                SqlCommand comando = new SqlCommand("UPDATE ICE_CUBES.ROL SET ROL_DESCRIPCION = @desc, ROL_ESTADO = @estado WHERE ROL_ID = @idRol", conexion, transaction);
                comando.Parameters.AddWithValue("@idRol", viejoRol.RolId);
                comando.Parameters.AddWithValue("@desc", viejoRol.RolDescripcion);
                comando.Parameters.AddWithValue("@estado", viejoRol.Estado);
                comando.ExecuteNonQuery();

                comando2.Parameters.AddWithValue("@idRol", viejoRol.RolId);
                int i = 0;
                foreach (Funcionalidad func in nuevoRol.Funcionalidades)
                {
                    comando2.CommandText = "INSERT INTO ICE_CUBES.ROL_FUNCIONALIDAD (ID_ROL,ID_FUNCIONALIDAD) VALUES (@idRol,@idFunc" + i + ")";
                    comando2.Parameters.AddWithValue("@idFunc" + i, func.IdFuncionalidad);
                    comando2.ExecuteNonQuery();
                    i++;
                }
                transaction.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                conexion.Close();
                throw ex;
            }
        }

        public void cargarNuevoRol(Rol unRol)
        { 
        
        }
    }
}
