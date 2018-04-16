using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace Logica.Tests
{
    [TestClass]
    public class CuentasCorrientesTests
    {
        [TestMethod]
        public void DeberiaPoderCrearUnaCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente(1000);
            cuentaCorriente.ID = 1;
            cuentaCorriente.Titular = "Seba";

            Assert.AreEqual(1, cuentaCorriente.ID);
            Assert.AreEqual("Seba", cuentaCorriente.Titular);
            Assert.AreEqual(0, cuentaCorriente.Saldo);
            Assert.AreEqual(1000, cuentaCorriente.GiroEnDescubierto);

            Assert.IsNotNull(cuentaCorriente.ListaMovimientos);
            Assert.IsFalse(cuentaCorriente.ListaMovimientos.Any());
        }

        [TestMethod]
        public void DeberiaPoderDepositarEnUnaCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente(1000);
            cuentaCorriente.ID = 1;
            cuentaCorriente.Titular = "Seba";

            cuentaCorriente.Depositar(100);

            Assert.AreEqual(100, cuentaCorriente.Saldo);
            Assert.AreEqual(1, cuentaCorriente.ListaMovimientos.Count);

            var movimiento = cuentaCorriente.ListaMovimientos.First();

            Assert.AreEqual(100, movimiento.Monto);
            Assert.AreEqual("Depósito", movimiento.Operacion);
            Assert.AreEqual(1, movimiento.Receptor);
            Assert.AreEqual(1, movimiento.Emisor);
            Assert.AreEqual(DateTime.Today, movimiento.fecha.Date);
        }

        [TestMethod]
        public void DeberiaPoderExtraerEnUnaCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente(1000);
            cuentaCorriente.ID = 1;
            cuentaCorriente.Titular = "Seba";

            cuentaCorriente.Depositar(100);
            cuentaCorriente.Extraer(50);

            Assert.AreEqual(50, cuentaCorriente.Saldo);
            Assert.AreEqual(2, cuentaCorriente.ListaMovimientos.Count);

            var movimiento = cuentaCorriente.ListaMovimientos.Last();

            Assert.AreEqual(50, movimiento.Monto);
            Assert.AreEqual("Extraccion", movimiento.Operacion);
            Assert.AreEqual(1, movimiento.Receptor);
            Assert.AreEqual(1, movimiento.Emisor);
            Assert.AreEqual(DateTime.Today, movimiento.fecha.Date);
        }

        [TestMethod]
        public void DeberiaPoderExtraerConDescubiertoEnUnaCuentaCorriente()
        {
            var cuentaCorriente = new CuentaCorriente(1000);
            cuentaCorriente.ID = 1;
            cuentaCorriente.Titular = "Seba";

            cuentaCorriente.Depositar(100);
            cuentaCorriente.Extraer(1100);

            Assert.AreEqual(-1000, cuentaCorriente.Saldo);
            Assert.AreEqual(2, cuentaCorriente.ListaMovimientos.Count);

            var movimiento = cuentaCorriente.ListaMovimientos.Last();

            Assert.AreEqual(1100, movimiento.Monto);
            Assert.AreEqual("Extraccion", movimiento.Operacion);
            Assert.AreEqual(1, movimiento.Receptor);
            Assert.AreEqual(1, movimiento.Emisor);
            Assert.AreEqual(DateTime.Today, movimiento.fecha.Date);
        }
    }
}