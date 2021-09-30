using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PagoRepository
    {
        private SqlConnection Conexion = null;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        private Pago Pago;
        public  List<Pago> Pagos = new List<Pago>();

        public PagoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public  void RegistrarPago(Pago Pago)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "insert into Pago (Id_Pago, Id_Cliente, Id_Credito,Fecha,Valor_pago) values(@Id_Pago, @Id_Cliente,@Id_Credito,@Fecha,@Valor_pago)";
                Comando.Parameters.Add("@Id_Credito", System.Data.SqlDbType.VarChar).Value = Pago.IdCredito;
                Comando.Parameters.Add("@Id_Cliente", System.Data.SqlDbType.VarChar).Value = Pago.IdCliente;
                Comando.Parameters.Add("@Id_Pago", System.Data.SqlDbType.VarChar).Value = Pago.IDPago;
                Comando.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime).Value = Pago.Fecha;
                Comando.Parameters.Add("@Valor_pago", System.Data.SqlDbType.VarChar).Value = Pago.ValorPago;
                Comando.ExecuteNonQuery();
            }
        }

        public  List<Pago> MostrarPagos()
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "Select * from Pago";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            while (Lector.Read())
            {
                Pago = new Pago
                {
                    IDPago = Lector["Id_Pago"].ToString(),
                    Fecha= Convert.ToDateTime(Lector["Fecha"]),
                    IdCliente = Lector["Id_Cliente"].ToString(),
                    IdCredito = Lector["Id_Credito"].ToString(),
                    ValorPago = Convert.ToDouble(Lector["Valor_pago"])
                };
                Pagos.Add(Pago);
            }
            return Pagos;
        }
        public string ObtenerCodigo()
        {
            string codigo;
            string Consulta = "select CodigoPago from Codigos";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            Lector.Read();
            codigo = Convert.ToString(Lector["CodigoPago"]);
            ActualizarCodigo(codigo);
            return codigo;
        }

        public void ActualizarCodigo(string codigo)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Codigos set codigoPago = {Convert.ToInt32(codigo)}+1";
                Comando.ExecuteNonQuery();

            }
        }
    }
}
