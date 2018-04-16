using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public class Banco
    {
        public string NombreBanco { get; set; }
        public  List<CuentaCorriente> ListaCuentaCorriente { get; set; }
        public List<CajaAhorro> ListaCajaAhorro { get; set; }

        

        private Banco()
        {

        }

        public void ExpresionesLambda()
        {
            /*
            var ordenadas = cuenta.Movimientos.OrderBy(x => x.Monto)
                .ThenByDescending(x => x.Emisor).ToList();

            var maximoMovimiento = cuenta.Movimientos.Max(x => x.Monto);

            var movimientosDistintoOrigen = cuenta.Movimientos
                .Where(x => x.Emisor != cuenta.NombreTitular).ToList();

            var saldoInicial = cuenta.Movimientos.Select(x => x.Monto).First();
            var saldos = new List<decimal>();
            saldos.Add(saldoInicial);

            for (int i = 1; i < cuenta.Movimientos.Count; i++)
            {
                var movimiento = cuenta.Movimientos[i];
                saldoInicial = saldoInicial + (movimiento.Tipo == TipoMovimiento.Extraccion
                                                ? movimiento.Monto * -1
                                                : movimiento.Monto);
                saldos.Add(saldoInicial);
            }

            var promedio = saldos.Average(x => x);

            var primero = cuenta.Movimientos.First();
            //var primero = cuenta.Movimientos.FirstOrDefault();

            var ultimo = cuenta.Movimientos.Last();
            //var ultimo = cuenta.Movimientos.LastOrDefault();

            var primerDeposito = cuenta.Movimientos.FirstOrDefault(x => x.Tipo == TipoMovimiento.Deposito);
            var ultimaExtraccion = cuenta.Movimientos.LastOrDefault(x => x.Tipo == TipoMovimiento.Extraccion);
       */
    
    }
        private static Banco banco = new Banco();
        private static List<Banco> ListaBanco = new List<Banco>();

        private static Banco BancoUnico = new Banco();

        public void AgregarBanco(string NombreBanco)
        {
            BancoUnico.NombreBanco = NombreBanco;
        }

        public static Banco ObtenerBanco()
        {
            if (BancoUnico == null)
            {
                BancoUnico = new Banco();
            }

            return BancoUnico;
        }

    }
}
