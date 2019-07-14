using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.model;
using FrbaCrucero.model.Operacion;
using System.Data.SqlClient;


namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Datos_Cliente : Form
    {
        Cliente cliente = null;
        Viaje viaje;
        List<Cabina> cabinasSeleccionadas;
        public Datos_Cliente(Viaje viaje, List<Cabina> cabinasSeleccionadas, Decimal dni)
        {
            InitializeComponent();
            this.viaje = viaje;
            this.cabinasSeleccionadas = cabinasSeleccionadas;
            this.dni.Text = dni.ToString();
            this.nacimiento.Value = Program.ObtenerFechaActual();
            nacimiento.MaxDate = Program.ObtenerFechaActual();
        }

        public Datos_Cliente(Viaje viaje, List<Cabina> cabinasSeleccionadas, Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.viaje = viaje;
            this.cabinasSeleccionadas = cabinasSeleccionadas;
            nombre.Text = cliente.nombre;
            apellido.Text = cliente.apellido;
            dni.Text = cliente.dni.ToString();
            direccion.Text = cliente.direccion;
            telefono.Text = cliente.telefono.ToString();
            nacimiento.Value = cliente.tieneNacimiento ? cliente.fechaNacimiento : Program.ObtenerFechaActual();
            nacimiento.MaxDate = Program.ObtenerFechaActual();
            mail.Text = cliente.mail;
        }

        private void pagarButton_Click(object sender, EventArgs e)
        {
            if (checkAndSaveCliente(this.cliente))
            {
                //DialogResult result = Program.openPopUpWindow(this, new Pago(viaje, cabinasSeleccionadas, cliente));
                //if (result == DialogResult.OK)
                //    this.DialogResult = DialogResult.OK;
            }
        }

        private void reservarButton_Click(object sender, EventArgs e)
        {
            if (checkAndSaveCliente(this.cliente))
            {
                Reserva reserva = this.crearReserva(viaje.viajeId, cliente.id, cabinasSeleccionadas);
                //Program.openNextWindow(this, new PantallaFinal(viaje, cabinasSeleccionadas, reserva));
                this.DialogResult = DialogResult.OK;
            }
        }


        private Boolean checkAndSaveCliente(Cliente cliente)
        {
            Boolean valido = true;
            Decimal dniNum = 0;
            Int32 telefonoNum = 0;
            if (String.IsNullOrWhiteSpace(nombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacio");
                valido = false;
            }
            if (String.IsNullOrWhiteSpace(apellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacio");
                valido = false;
            }
            if (String.IsNullOrWhiteSpace(direccion.Text))
            {
                MessageBox.Show("La direccion no puede estar vacio");
                valido = false;
            }
            if (String.IsNullOrWhiteSpace(dni.Text) || !Decimal.TryParse(dni.Text, out dniNum))
            {
                MessageBox.Show("El DNI no puede estar vacio y debe ser un numero valido");
                valido = false;
            }
            if (String.IsNullOrWhiteSpace(telefono.Text) || !Int32.TryParse(telefono.Text, out telefonoNum))
            {
                MessageBox.Show("El numero de telefono no puede estar vacio y debe ser valido");
                valido = false;
            }
            if (valido)
            {
                if (this.cliente == null)
                    this.cliente = this.crearCliente(nombre.Text, apellido.Text, dniNum, direccion.Text, telefonoNum, mail.Text, nacimiento.Value);
                else
                {
                    this.cliente.nombre = nombre.Text;
                    this.cliente.apellido = apellido.Text;
                    this.cliente.dni = dniNum;
                    this.cliente.direccion = direccion.Text;
                    this.cliente.telefono = telefonoNum;
                    this.cliente.mail = mail.Text;
                    this.cliente.fechaNacimiento = nacimiento.Value;
                    this.cliente.tieneNacimiento = true;
                    this.actualizarCliente(this.cliente);
                }
            }
            return valido;
        }


        public Cliente crearCliente(String nombre, String apellido, Decimal dni, String direccion, Int32 telefono, String mail, DateTime fechaNacimiento)
        {
            SqlParameter ret = new SqlParameter("@ret", SqlDbType.Int);
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("ice_cubes.sp_CrearCliente", conexion);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@nombre", nombre);
                consulta.Parameters.AddWithValue("@apellido", apellido);
                consulta.Parameters.AddWithValue("@direccion", direccion);
                consulta.Parameters.AddWithValue("@telefono", telefono);
                consulta.Parameters.AddWithValue("@dni", dni);
                consulta.Parameters.AddWithValue("@mail", mail);
                consulta.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                ret.Direction = ParameterDirection.ReturnValue;
                consulta.Parameters.Add(ret);
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

            Int32 cod = Convert.ToInt32(ret.Value);

            return new Cliente(cod, nombre, apellido, dni, direccion, telefono, mail, fechaNacimiento, true);
        }


        public void actualizarCliente(Cliente cliente)
        {
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("UPDATE ice_cubes.Cliente SET CLIE_NOMBRE = @nombre, CLIE_APELLIDO = @apellido, CLI_DIR = @direccion, CLI_TELEFONO = @telefono, CLIE_DNI = @dni, CLI_MAIL = @mail, CLI_FECHA_NAC = @nacimiento WHERE CLI_ID = @cod", conexion);
                consulta.Parameters.AddWithValue("@nombre", cliente.nombre);
                consulta.Parameters.AddWithValue("@apellido", cliente.apellido);
                consulta.Parameters.AddWithValue("@direccion", cliente.direccion);
                consulta.Parameters.AddWithValue("@telefono", cliente.telefono);
                consulta.Parameters.AddWithValue("@dni", cliente.dni);
                consulta.Parameters.AddWithValue("@mail", cliente.mail);
                consulta.Parameters.AddWithValue("@nacimiento", cliente.fechaNacimiento);
                consulta.Parameters.AddWithValue("@cod", cliente.id);
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



        public Reserva crearReserva(Int32 cod_viaje, decimal cod_cliente, List<Cabina> cabinas)
        {
            Reserva reserva = null;
            SqlConnection conexion = ConexionSQLS.getConeccion();
            SqlTransaction transaction = null;
            try
            {
                SqlCommand consulta = new SqlCommand("MLJ.crearPasaje", conexion);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@cod_cliente", cod_cliente);
                consulta.Parameters.AddWithValue("@cod_viaje", cod_viaje);
                //consulta.Parameters.AddWithValue("@cabinas", Cabina.formatearLista(cabinas));
                SqlParameter ret = new SqlParameter();
                ret.Direction = ParameterDirection.ReturnValue;
                consulta.Parameters.Add(ret);
                conexion.Open();

                transaction = conexion.BeginTransaction();
                consulta.Transaction = transaction;

                consulta.ExecuteNonQuery();

                Int32 cod_pasaje = Convert.ToInt32(ret.Value);

                consulta.Parameters.Clear();
                consulta.CommandText = "MLJ.crearReserva";
                consulta.Parameters.Add(ret);
                consulta.Parameters.AddWithValue("@cod_pasaje", cod_pasaje);
                consulta.Parameters.AddWithValue("@fecha", Program.ObtenerFechaActual());

                consulta.ExecuteNonQuery();

                Int32 cod_reserva = Convert.ToInt32(ret.Value);
                //reserva = new Reserva(cod_reserva, cod_pasaje, Program.ObtenerFechaActual());
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return reserva;
        }
    }


   
}
