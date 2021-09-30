using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CreditoRepository
    {
        private SqlConnection Conexion = null;
        private SqlCommand OrdenSql;
        private SqlDataReader Lector;
        public  List<Credito> Creditos = new List<Credito>();
        public  Credito Credito;

        public CreditoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public void RegistrarCredito(Credito credito)
        {
            using (var Comando = Conexion.CreateCommand())
            { 
                Comando.CommandText = "Insert into Credito (Id_Credito, Id_Cliente, Saldo, Cuota, NumeroCuotas, interes) values(@Id_Credito, @Id_Cliente, @Saldo, @Cuota, @NumeroCuotas, @Interes)";
                Comando.Parameters.Add("@Id_Credito", System.Data.SqlDbType.VarChar).Value = credito.IdCredito;
                Comando.Parameters.Add("@Id_cliente", System.Data.SqlDbType.VarChar).Value = credito.Id_Cliente;
                Comando.Parameters.Add("@Saldo", System.Data.SqlDbType.VarChar).Value = credito.Saldo;
                Comando.Parameters.Add("@Cuota", System.Data.SqlDbType.VarChar).Value = credito.Cuota;
                Comando.Parameters.Add("@NumeroCuotas", System.Data.SqlDbType.VarChar).Value = credito.NumeroCuotas;
                Comando.Parameters.Add("@Interes", System.Data.SqlDbType.VarChar).Value = credito.Interes;
                Comando.ExecuteNonQuery();
            }
        }
        public  Credito BuscarCredito(String IdentificacionClente)
        {
            MostrarCreditos()
;            List<Credito> creditoEncontrados = Creditos.FindAll(creditoss => creditoss.Id_Cliente == IdentificacionClente);
            Credito = creditoEncontrados[0];
            return Credito;
        }
        public  void ActualizarCredito(Credito credito)
        {
            ActualizarCreditoSql(credito);
        }
        private void ActualizarCreditoSql(Credito credito)
        {
            Conexion.Close();
            Conexion.Open();

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Credito set Saldo = {credito.Saldo}, Cuota = {credito.Cuota}, NumeroCuotas = {credito.NumeroCuotas}where id_Credito = {credito.IdCredito}";
                Comando.ExecuteNonQuery();
            }
        }
        public  List<Credito> MostrarCreditos()
        {
            Conexion.Close();
            Conexion.Open();
            string Consulta = "Select * from Credito";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            while (Lector.Read())
            {
                Credito = new Credito
                {
                    Id_Cliente = Lector["Id_Cliente"].ToString(),
                    IdCredito = Lector["Id_Credito"].ToString(),
                    Saldo = Convert.ToDouble(Lector["Saldo"]),
                    Cuota = Convert.ToDouble(Lector["Cuota"]),
                    NumeroCuotas = Convert.ToInt32(Lector["NumeroCuotas"]),
                    Interes = Convert.ToDouble(Lector["Interes"])
                };
                Creditos.Add(Credito);
            }
            return Creditos;
        }

        public string ObtenerCodigo()
        {
            string codigo;
            string Consulta = "select CodigoCredito from Codigos";
            OrdenSql = new SqlCommand(Consulta, Conexion);
            Lector = OrdenSql.ExecuteReader();
            Lector.Read();
            codigo = Convert.ToString(Lector["codigoCredito"]);
            ActualizarCodigo(codigo);
            return codigo;
        }
        
        public void ActualizarCodigo(string codigo)
        {
            Conexion.Close();
            Conexion.Open();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = $"update Codigos  set codigoCredito = {Convert.ToInt32(codigo)}+1";
                Comando.ExecuteNonQuery();

            }
        }
    }
}
