using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;
using Infraestructura;

namespace BLL
{
    public  class CreditoServices
    {
        private SqlConnection Conexion = null;
        public  Credito Credito;
        CreditoRepository CreditoRepository;
        List<Credito> Creditos;

        public CreditoServices()
        {
            string strConexion = "server=DESKTOP-RRS35AE ; database=Paymenttofees ; integrated security = true";
            Conexion = new SqlConnection(strConexion);
            CreditoRepository = new CreditoRepository(Conexion);
        }
        public void Registrar(Credito credito)
        {
            Conexion.Open();

            credito.IdCredito = CreditoRepository.ObtenerCodigo();
            CreditoRepository.RegistrarCredito(credito);
            Conexion.Close();
        }

        public Credito BuscarCedito(String IdentifiacionCliente)
        {
            Conexion.Open();
            CreditoRepository.BuscarCredito(IdentifiacionCliente);
            Conexion.Close();
            return CreditoRepository.Credito;
        }
        public void ActualizarCredito(Credito credito)
        {
            Conexion.Open();
            CreditoRepository.ActualizarCredito(credito);
            Conexion.Close();
        }
        public void GenerarExcel()
        {
            Excel excel = new Excel();
            excel.GenerarReporteCreditos(CreditoRepository.Creditos);
        }
        public List<Credito> MostrarCredito()
        {
            Conexion.Open();
            Creditos = CreditoRepository.MostrarCreditos();
            Conexion.Close();
            return Creditos;
        }
    }
}
