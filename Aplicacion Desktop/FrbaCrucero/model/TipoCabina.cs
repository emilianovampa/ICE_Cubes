using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FrbaCrucero.model
{
    enum TipoCabina
    {
        [Description("Económica")] economica = 1,
        [Description("Económica")] ejecutiva = 1.2,
        [Description("Económica")] primera = 1.5
    }
}
