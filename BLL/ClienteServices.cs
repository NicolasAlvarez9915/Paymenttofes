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
    public  class ClienteServices
    {
        private SqlConnection Conexion = null;
        public  Cliente cliente;
        public List<Cliente> Clientes;
        ClienteRepository ClienteRepository;
        CreditoServices CreditoServices;

        public ClienteServices()
        {
            string strConexion = "server=DESKTOP-RRS35AE ; database=Paymenttofees ; integrated security = true";
            Conexion = new SqlConnection(strConexion);
            ClienteRepository = new ClienteRepository(Conexion);
            CreditoServices = new CreditoServices();
             
        }

        public  List<Cliente> MostrarClientes()
        {
            Conexion.Open();
            Clientes = ClienteRepository.MostrarClientes();
            Conexion.Close();
            return Clientes;
        }
        public  void ActualizarEstado(String Identificacion)
        {
            Conexion.Open();
            ClienteRepository.ActualizarEstado(Identificacion);
            Conexion.Close();
        }
        public  String Registrar(Cliente cliente, Credito credito)
        {
            Correo correo = new Correo();
            String mensajeCorreo;
            Conexion.Open();
            if (ClienteRepository.BuscarExisteCliente(cliente.Identificacion))
            {
                if (ClienteRepository.BuscarEstadoCliente(cliente.Identificacion))
                {
                    CreditoServices.Registrar(credito);
                    mensajeCorreo = correo.EnviarEmail(cliente);
                    Conexion.Close();
                    return $"Ya Existe un cliente registrado con esta identificacion pero su estado es Inactivo. Se volvio activo y se le hizo el prestamo. {mensajeCorreo}";
                }
                else
                {
                    Conexion.Close();
                    return "Ya existe un cliente con esta identificacion pero su estado es activo, asi que no se puede hacer el prestamo.";
                }
            }
            mensajeCorreo = correo.EnviarEmail(cliente);
            ClienteRepository.RegistrarCliente(cliente);
            CreditoServices.Registrar(credito);
            Conexion.Close();
            return $"Registrado correctamente. {mensajeCorreo}";
        }

        public  bool BuscarInformacion(String Identificacion)
        {
            Conexion.Open();
            if (ClienteRepository.BuscarInformacion(Identificacion))
            {
                Conexion.Close();
                return true;
            }
            Conexion.Close();
            return false;
        }

        public void GenerarExcel()
        {
            Excel excel = new Excel();
            excel.GenerarReporteClientes(ClienteRepository.Clientes);
        }
        public  Cliente InformacionCliente()
        {
            return ClienteRepository.cliente;
        }

    }
}
