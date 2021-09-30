using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;

namespace BLL
{
    public class CarteraServices
    {
        private SqlConnection Conexion = null;
        CarteraRepository CarteraRepository;
        public Cartera Cartera;
        public CarteraServices()
        {
            string strConexion = "server=DESKTOP-RRS35AE ; database=Paymenttofees ; integrated security = true";
            Conexion = new SqlConnection(strConexion);
            CarteraRepository = new CarteraRepository(Conexion);
        }
        public void ActualizarCanttidadDeudoresMenos ()
        {
            Conexion.Open();
            CarteraRepository.ActualizarCantidadDeudoresMenos();
            Conexion.Close();
        }
        public  void ActualizarCanttidadDeudores()
        {
            Conexion.Open();
            CarteraRepository.ActualizarCantidadDeudores();
            Conexion.Close();
        }
        public void ActualizarDineroPrestado(double CantidadPrestado)
        {
            Conexion.Open();
            CarteraRepository.ActualizarDineroPrestado(CantidadPrestado);
            Conexion.Close();
        }

        public  void ActualizarDineroRestante(double CantidadAbono)
        {
            Conexion.Open();
            CarteraRepository.ActualizarDineroRestante(CantidadAbono);
            Conexion.Close();
        }

        public bool ValidarDineroRestante(double CantidadPrestamo)
        {
            bool SiNo;
            Conexion.Open();
            SiNo = CarteraRepository.ValidarDineroRestante(CantidadPrestamo);
            Conexion.Close();
            return SiNo;
        }
        public Cartera MostrarCartera()
        {
            Conexion.Open();
            Cartera = CarteraRepository.MostrarCartera();
            Conexion.Close();
            return Cartera;
        }
    }
}
