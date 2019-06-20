using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public enum TipoServicio
    {
        [Description("Transporte de Mercaderias")] transporte,
        [Description("Turismo")] turismo,
        [Description("Silversea")]Silversea
    }
}
