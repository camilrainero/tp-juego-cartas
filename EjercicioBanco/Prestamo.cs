using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    public class Prestamo
    {
        public string Titular { get; set; }
        public decimal Interes { get; set; }
        public decimal Monto { get; set; }
        public int Cuotas { get; set; }

        public Prestamo()
        {

        }

        public Prestamo titular (string Titular)
        {
            this.Titular = Titular;
            return this;
        }

        public Prestamo interes(decimal Interes)
        {
            this.Interes = Interes;
            return this;
        }

        public Prestamo cuotas(int Cuotas)
        {
            this.Cuotas = Cuotas;
            return this;
        }

        public Prestamo pagar(int Cuotas, decimal Monto)
        {
            Console.WriteLine("Se paga la cuota" + Cuotas + " con el monto " + Monto);
        }



    }
}
