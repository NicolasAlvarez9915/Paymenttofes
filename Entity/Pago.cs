using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago
    {
        public string IDPago { get; set; }
        public string IdCredito { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double ValorPago { get; set; }
    }
}
