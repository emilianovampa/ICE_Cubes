using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaCrucero
{
    public class ParametroStore
    {
        string Variable {get;set;}
        object Valor { get; set; }
        ParameterDirection tipoVariable { get; set; }
        private string p;
        private string usuario;
        private ParameterDirection parameterDirection;

        public ParametroStore(string p, string usuario, ParameterDirection parameterDirection)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.usuario = usuario;
            this.parameterDirection = parameterDirection;
        }
    }
}
