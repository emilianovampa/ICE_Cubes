using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.model;
using System.Windows.Forms;
using System.ComponentModel;

namespace FrbaCrucero
{
    public class ListadoRecorridoController : SeleccionadorDePuerto
    {
        private ListadoRecorridosView vista;
        private ModoInteraccion modo;
        private List<Recorrido> recorridos;
        private SeleccionadorRecorrido caller;

        private Puerto puertoSeleccionado = null;
        private  Puerto origen;
        private  Puerto destino;
        private  Puerto pasaPor;
        private decimal precioDesde = 0;
        private decimal precioHasta = 0;
        private Recorrido recorridoSeleccionado;

        public ListadoRecorridoController(ListadoRecorridosView listadoRecorridosView, SeleccionadorRecorrido caller, ModoInteraccion modo)
        {
            // TODO: Complete member initialization
            this.vista = listadoRecorridosView;
            this.caller = caller;
            this.modo = modo;
        }
        // Inicializador
        internal void inicializarDatos()
        {
            //Seteo de Modificacion o visualización:
            vista.habilitarBotonesABM(modo.Equals(ModoInteraccion.MODIFICAR));

            //Habilito la seleccion si quien lo llamo sabe recibirlo
            vista.habilitarBotonesSeleccion(caller != null);

            vista.habilitarTransferir(caller != null && (recorridoSeleccionado != null && recorridoSeleccionado.estado));

            vista.setEstadoDefault();
        }
        
        // Framework con Seleccionador de Puerto
        public void seleccionarPuerto(Puerto puerto)
        {
            this.puertoSeleccionado = puerto;
        }
        internal void buscarPuerto()
        {
            SeleccionarPuertoView buscadorPuerto = new SeleccionarPuertoView(this);
            vista.Hide();
            buscadorPuerto.ShowDialog();
            vista.Show();
        }
        public void setOrigen()
        {
            if (puertoSeleccionado != null)
            {
                this.origen = puertoSeleccionado;
                vista.setOrigen(this.origen.nombre);
                puertoSeleccionado = null;
            }
        }
        internal void setDestino()
        {
            if (puertoSeleccionado != null)
            {
                this.destino = puertoSeleccionado;
                vista.setDestino(this.destino.nombre);
                puertoSeleccionado = null;
            }
        }
        internal void setPasaPor()
        {
            if (puertoSeleccionado != null)
            {
                this.pasaPor = puertoSeleccionado;
                vista.setPasaPor(this.pasaPor.nombre);
                puertoSeleccionado = null;
            }
        }

        //Botones

        internal void limpiarDatos()
        {
           this.origen = null;
           vista.setOrigen("");
           this.destino = null;
           vista.setDestino("");
           this.pasaPor = null;
           vista.setPasaPor("");
           vista.setPrecioDesde(0);
           vista.setPrecioHasta(0);
           precioDesde = 0;
           precioHasta = 0;
           vista.setEstadoDefault(); 
        }

        internal void buscarRecorridos()
        {
 	        recorridos = Recorrido.listarRecorridos(generarWhere());
            vista.setRecorridos(new BindingSource(recorridos, null));
        }
        
        private string generarWhere(){

            string where = " ";
            string inicio = "WHERE ";

            if (this.origen != null)
            {
                where = where + inicio + "EXISTS (SELECT null FROM [GD1C2019].[ICE_CUBES].[TRAMO] tr2 WHERE tr2.TRAMO_RECO_ID = t.[TRAMO_RECO_ID] AND tr2.TRAMO_NIVEL = 0 "
		                + "AND tr2.[TRAMO_ORIGEN] =" + this.origen.idPuerto.ToString() + ")";

                inicio = "AND ";

            }
            if (this.destino != null) 
            {
                where = where + inicio +"EXISTS (SELECT null FROM [GD1C2019].[ICE_CUBES].[TRAMO] tr2 WHERE tr2.TRAMO_RECO_ID = t.[TRAMO_RECO_ID] "
                        + "AND NOT EXISTS(SELECT null FROM [GD1C2019].[ICE_CUBES].[TRAMO] tr3 WHERE tr3.TRAMO_NIVEL > tr2.TRAMO_NIVEL )"
			            + "AND tr2.[TRAMO_DESTINO] = "+ this.destino.idPuerto.ToString()  +")";
                inicio = "AND ";
            }

            if (this.pasaPor != null)
            {
                where = where + inicio + "EXISTS (SELECT null FROM [GD1C2019].[ICE_CUBES].[TRAMO] tr2 WHERE tr2.TRAMO_RECO_ID = t.[TRAMO_RECO_ID]"
			            + "AND (tr2.[TRAMO_ORIGEN] = " + this.pasaPor.idPuerto.ToString()
                        + "  OR tr2.[TRAMO_DESTINO] = " + this.pasaPor.idPuerto.ToString() + "))";
                inicio = "AND ";
            }

            if (this.precioDesde > 0 || this.precioHasta > 0)
            {
                if (this.precioHasta > 0)
                {
                    where = where + inicio + "(select SUM(TRAMO_PRECIO) FROM ice_cubes.TRAMO where TRAMO_RECO_ID = r.RECO_ID) BETWEEN "
                        + this.precioDesde.ToString() + " AND " + this.precioHasta.ToString();
                }
                else
                {
                    where = where + inicio + "(select SUM(TRAMO_PRECIO) FROM ice_cubes.TRAMO where TRAMO_RECO_ID = r.RECO_ID) > "
                        + this.precioDesde.ToString();
                }
                inicio = "AND ";
            }

            if (vista.getEstado() > 0)
            {
                if (vista.getEstado().Equals(1)) //Solo Activos
                {
                    where = where + inicio + "RECO_ESTADO = 1";
                }
                if (vista.getEstado().Equals(2)) //Solo Eliminados
                {
                    where = where + inicio + "RECO_ESTADO = 0";
                }
                inicio = "AND ";
            }
            return where;
        }

        internal void select(int p)
        {
            recorridoSeleccionado = recorridos[p];
            vista.setRecorridoSeleccionado(new BindingSource(recorridos[p].tramos, null));
            vista.habilitarTransferir(caller != null && (recorridoSeleccionado != null && recorridoSeleccionado.estado));

        }

        internal void edit(int p)
        {
            RecorridoView editarRecorrido = new RecorridoView(recorridos[p],ModoInteraccion.MODIFICAR);
            vista.Hide();
            editarRecorrido.ShowDialog();
            vista.Show();
            buscarRecorridos();
        }
    
        internal void agregarNuevoRecorrido()
        {
 	        RecorridoView altaRecorrido = new RecorridoView(new Recorrido(0,null, true), ModoInteraccion.MODIFICAR);
            vista.Hide();
            altaRecorrido.ShowDialog();
            vista.Show();
            buscarRecorridos();
        }
        
        internal void transferirSeleccionado() // Pasa el Recorrido seleccionado a quien lo haya llamado.
        {
            caller.recibirRecorridoSeleccionado(recorridoSeleccionado);
            vista.Close();
        }

        internal void setPrecioDesde(string p)
        {
            if (p == "")
            {
                precioDesde = 0;
            }
            else
            {
                precioDesde = decimal.Parse(p);
            }

        }

        internal void setPrecioHasta(string p)
        {
            if (p == "")
            {
                precioHasta = 0;
            }
            else
            {
                precioHasta = decimal.Parse(p);
            }
        }
    }
}
