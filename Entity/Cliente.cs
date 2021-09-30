using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Entity
{
    public class Cliente
    {
        
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Identificacion { get; set; }
            public string Estado { get; set; }

            public Cliente()
            {
            }
    }
}
