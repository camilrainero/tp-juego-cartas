using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public enum TipoOperacion
    {
        Extraccion, Deposito, ConsultarSaldo
    }
    public class Movimientos
    {
        public DateTime Fecha { get; set; }
        public double Monto{ get; set; }
        public TipoOperacion Operacion { get; set; }
        public int Emisor { get; set; }
    }
}
