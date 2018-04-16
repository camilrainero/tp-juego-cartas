using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public class CuentaCorriente:CuentaBancaria
    {
        public int Descubierto { get; set; }
        public int prueba { get; set; }

        private static List<CuentaCorriente> ListaCuentaCorriente = new List<CuentaCorriente>();

        public CuentaCorriente()
        {
            this.Descubierto = -5000;
        }
        
        public override void Extraer(double Monto, int Emisor)
        {
            if (Monto<=Descubierto)
            {
                this.Saldo -= Monto;
            }           

            Movimientos Movimientos = new Movimientos();

            Movimientos.Fecha = DateTime.Now;
            Movimientos.Operacion = TipoOperacion.Extraccion;
            Movimientos.Emisor = Emisor;
            Movimientos.Monto = Monto;

            GuardarExtraccion(Movimientos);
            
        }

        public static CuentaCorriente AgregarTitular(string Titular)
        {
            foreach (var item in ListaCuentaCorriente)
            {
                if (item.Titular==Titular)
                {
                    return item;
                }
            }


        
            this.Titular = Titular;
            CuentaBancaria.Saldo = 0;
            CuentaBancaria.NumeroCuenta = 4;
         ListaCuentaCorriente.Add(CuentaBancaria);
            return CuentaBancaria;

        }
    }
}
