using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public class CajaAhorro:CuentaBancaria
    {
        public override void Extraer(double Monto, int Emisor)
        {
            if (this.Saldo>0 && this.Saldo>Monto)
            {
                this.Saldo -= Monto;

                Movimientos Movimientos = new Movimientos();

                Movimientos.Fecha = DateTime.Now;
                Movimientos.Operacion = TipoOperacion.Extraccion;
                Movimientos.Emisor = Emisor;
                Movimientos.Monto = Monto;

                GuardarExtraccion(Movimientos);
            }
            
        }
    }
}
