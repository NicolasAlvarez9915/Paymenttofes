using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class CarteraRepository
    {
        private SqlConnection Conexion = null;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        public Cartera Cartera = new Cartera();
        
        public CarteraRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }

        
        public  void ActualizarDineroPrestado(double CantidadPrestado)
        {
            MostrarCartera();
            Cartera.DineroPrestado += CantidadPrestado;
            ActualizarCartera("Dinero_Prestado", Cartera.DineroPrestado.ToString());
            Cartera.DineroRestante -= CantidadPrestado;
            ActualizarCartera("Dinero_Restante", Cartera.DineroRestante.ToString());
        }

        public  void ActualizarDineroRestante(Double CantidadAbono)
        {
            MostrarCartera();
            Cartera.DineroPrestado -= CantidadAbono;
            if(Cartera.DineroPrestado < 0)
            {
                Cartera.DineroPrestado = 0;
            }
            ActualizarCartera("Dinero_Prestado", Cartera.DineroPrestado.ToString());
            Cartera.DineroRestante += CantidadAbono;
            if(Cartera.DineroRestante > 30000000)
            {
                Cartera.DineroRestante = 30000000;
            }
            ActualizarCartera("Dinero_Restante", Cartera.DineroRestante.ToString());
        }
        public void ActualizarCantidadDeudoresMenos()
        {
            MostrarCartera();
            Cartera.CantidadDeudores--;
            ActualizarCartera("Cantidad_Deudores", Cartera.CantidadDeudores.ToString());
        }
        public  void ActualizarCantidadDeudores()
        {
            MostrarCartera();
            Cartera.CantidadDeudores++;
            ActualizarCartera("Cantidad_Deudores", Cartera.CantidadDeudores.ToString());
        }
        public  bool ValidarDineroRestante(Double CantidadPrestamo)
        {
            MostrarCartera();
            if(Cartera.DineroRestante - CantidadPrestamo < 50)
            {
                return true;
            }
            return false;
        }
        public  Cartera MostrarCartera()
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "select * from Cartera";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            Lector.Read();
            Cartera.CantidadDeudores = Convert.ToInt32(Lector["Cantidad_Deudores"]);
            Cartera.Capital = Convert.ToDouble(Lector["Capital"]);
            Cartera.DineroPrestado = Convert.ToDouble(Lector["Dinero_Prestado"]);
            Cartera.DineroRestante = Convert.ToDouble(Lector["Dinero_Restante"]);
            return Cartera;
        }
        
        public void ActualizarCartera(string Campo, String valor)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText=$"update Cartera Set {Campo} = {valor}";
                Comando.ExecuteNonQuery();
            }
        }
    }
}
