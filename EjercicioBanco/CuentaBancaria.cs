using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public abstract class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public double Saldo { get; set; }
        public string Titular { get; set; }
        public List<Movimientos> ListaMovimientos { get; set; }

        public CuentaBancaria()
        {
            this.ListaMovimientos = new List<Movimientos>();
        }

        
        public void Depositar(double Monto, int Emisor)
        {
            this.Saldo += Monto;

            Movimientos Movimientos = new Movimientos();

            Movimientos.Fecha = DateTime.Now;
            Movimientos.Operacion = TipoOperacion.Deposito;
            Movimientos.Emisor = Emisor;
            Movimientos.Monto = Monto;

            ListaMovimientos.Add(Movimientos);
        }

        public abstract void Extraer(double Monto, int Emisor);

        public void GuardarExtraccion(Movimientos Movimiento)
        {
            this.ListaMovimientos.Add(Movimiento);
        }

        public double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public Movimientos ObtenerMayorExtraccion()
        {
           Movimientos Movimientos = this.ListaMovimientos.Where(x => x.Operacion == TipoOperacion.Extraccion).OrderByDescending(x => x.Monto).First();

            return Movimientos;
        }

        public double ObtenerMayorDeposito()
        {
            double MayorDeposito = this.ListaMovimientos.Where(x => x.Operacion == TipoOperacion.Deposito).Max(x => x.Monto);

            return MayorDeposito;
        }


    }
}

    
