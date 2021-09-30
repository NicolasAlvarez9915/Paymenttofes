using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public  class PagoServices
    {
        PagoRepository PagoRepository;

        private SqlConnection Conexion = null;

        public PagoServices()
        {
            string strConexion = "server=DESKTOP-RRS35AE ; database=Paymenttofees ; integrated security = true";
            Conexion = new SqlConnection(strConexion);
            PagoRepository = new PagoRepository(Conexion);
        }
        public  void RegistrarPago(Pago Pago)
        {
            Conexion.Open();
            Pago.IDPago = PagoRepository.ObtenerCodigo();
            PagoRepository.RegistrarPago(Pago);
            Conexion.Close();
        }
        public void GenerarExcel()
        {
            Excel excel = new Excel();
            excel.GenerarReportePagos(PagoRepository.Pagos);
        }
        public  List<Pago> MostrarPagos()
        {
            Conexion.Open();
            List<Pago> pagos = PagoRepository.MostrarPagos();
            Conexion.Close();
            return pagos;
        }
    }
}
