using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DAL
{
    public  class ClienteRepository
    {
        private SqlConnection Conexion = null;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        public  List<Cliente> Clientes = new List<Cliente>();
        public  Cliente cliente;

        public ClienteRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public  List<Cliente> MostrarClientes()
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "Select * from Cliente";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            while (Lector.Read())
            {
                cliente = new Cliente
                {
                    Identificacion = Lector["Identificacion"].ToString(),
                    Nombre = Lector["Nombre"].ToString(),
                    Correo = Lector["Correo"].ToString(),
                    Direccion = Lector["Direccion"].ToString(),
                    Estado = Lector["Estado"].ToString(),
                    Telefono = Lector["Telefono"].ToString()
                };
                Clientes.Add(cliente);
            }
            return Clientes;
        }
        public void ActualizarEstado(String Identificacion)
        {
            MostrarClientes();
            List<Cliente> EstadoCliente = Clientes.FindAll(cliente => cliente.Identificacion == Identificacion);
            EstadoCliente[0].Estado = "Inactivo";
            ActualizarCliente("Estado", EstadoCliente[0].Estado, EstadoCliente[0].Identificacion);        
        }
        private  void ActualizarCliente(String Campo, string valor, string Identificacion)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Cliente Set {Campo} = '{valor}' where Identificacion = {Identificacion}";
                Comando.ExecuteNonQuery();
            }
        }
        public  bool BuscarExisteCliente(String Identificacion)
        {
            MostrarClientes();
            List<Cliente> ExisteCliente = Clientes.FindAll(cliente => cliente.Identificacion == Identificacion);
            if (ExisteCliente.Count() == 0)
            {
                return false;
            }
            return true;
        }
        public  bool BuscarInformacion(String Identificacion)
        {
            MostrarClientes();
            List<Cliente> ExisteCliente = Clientes.FindAll(cliente => cliente.Identificacion == Identificacion);
            if (ExisteCliente.Count() == 0)
            {
                return false;
            }
            cliente = ExisteCliente[0];
            return true;
        }
        public  bool BuscarEstadoCliente(String Identificacion)
        {
            MostrarClientes();
            List<Cliente> EstadoCliente = Clientes.FindAll(cliente => cliente.Identificacion == Identificacion && cliente.Estado == "Inactivo");
            if (EstadoCliente.Count() == 0)
            {
                return false;
            }
            ActualizarCliente("Estado", "Activo", EstadoCliente[0].Identificacion);
            return true;
        }
        public  void RegistrarCliente(Cliente cliente)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into Cliente (Identificacion, Nombre, Correo, Telefono, Direccion) values(@Identificacion, @Nombre, @Correo, @Telefono, @Direccion)";
                Comando.Parameters.Add("@Identificacion", System.Data.SqlDbType.VarChar).Value = cliente.Identificacion;
                Comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = cliente.Nombre;
                Comando.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar).Value = cliente.Correo;
                Comando.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar).Value = cliente.Telefono;
                Comando.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar).Value = cliente.Direccion;
                Comando.ExecuteNonQuery();
            }
            Conexion.Close();
        }


    }
}
