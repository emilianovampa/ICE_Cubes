using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FrbaCrucero.model
{
    public enum TipoCabina
    {
        [Description("Económica")] economica = 1,
        [Description("ejecutiva")] ejecutiva = 2,
        [Description("primera")] primera = 3
    }
}
