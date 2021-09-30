using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Credito : IServicionFinanciero
    {
        public Credito()
        {
        }

        public string IdCredito { get; set; }
        public string Id_Cliente { get; set; }
        public double Saldo { get; set; }
        public double Cuota { get; set; }
        public int NumeroCuotas { get; set; }
        public double Interes { get; set; }
        public void AplicarInteres()
        {
            Saldo += Interes;
            CalcularValorCuota();
        }
        public string CalcularValorCuota()
        {
            Cuota = Saldo / NumeroCuotas;
            return $"el valor de cada cuota es : {Cuota}";
        }
        public string CalcularSaldo(double prestamo)
        {
            Saldo = prestamo*0.16 + prestamo;

            return $"el valor total de su prestamo a pagar es : {Saldo}";
        }
        public string Abonar(string tipoPago, double Abono, int CantidadCuotas)
        {
            return tipoPago switch
            {
                "Cuotas" => AbonarCuota(CantidadCuotas),
                "Cantidad de dinero" => AbonarDinero(Abono),
                _ => "No se pudo abonar",
            };
        }
        public string AbonarDinero(double Abono)
        {
            double CantidadCoutoas = Abono / Cuota;
            double decimalAbono = CantidadCoutoas - Math.Floor(CantidadCoutoas);
            AbonarCuota(Convert.ToInt32(Math.Floor(CantidadCoutoas)));
            decimalAbono *= Cuota;
            Saldo -= decimalAbono;
            CalcularValorCuota();
            ValidarSaldo();
            return "Abono Exitoso";
        }
        public string AbonarCuota(int CantidadCuotas)
        {
            Saldo -= Cuota * CantidadCuotas;
            NumeroCuotas -= CantidadCuotas;
            ValidarSaldo();
            return "Abono Exitoso";
        }
        private void ValidarSaldo()
        {
            if (Saldo <=0)
            {
                Cuota = 0;
                NumeroCuotas = 0;
                Saldo = 0;
            }
        }
    }
}
