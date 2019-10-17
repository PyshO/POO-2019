using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public class Datos_Cuenta
    {
        //Aqui se crea la lista de datos de la clase pensiones
        public List<Pensiones> Pensiones()
        {
            List<Pensiones> pensiones = new List<Pensiones>();
            pensiones.Add(new Pensiones { No_Cuenta = 12345, Cotizacion = 12, Interes = 1000, Numero = 12345, Saldo = 1000, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 23434, Cotizacion = 12, Interes = 1000, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("14/07/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 23434, Cotizacion = 12, Interes = 16, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 23434, Cotizacion = 12, Interes = 16, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("14/07/2024") });
            pensiones.Add(new Pensiones { No_Cuenta = 23434, Cotizacion = 12, Interes = 12, Numero = 42423, Saldo = 45424, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            return pensiones;
        }

        //Aqui se crea la lista de datos de la clase Cuenta ahorro
        public List<Cuenta_Ahorro> Ahorros()
        {
            List<Cuenta_Ahorro> ahorros = new List<Cuenta_Ahorro>();
            ahorros.Add(new Cuenta_Ahorro { Interes = 11, Numero = 12345, Saldo = 453545.654, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 13, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("14/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 34, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            ahorros.Add(new Cuenta_Ahorro { Interes = 12, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("14/07/2024") });
            ahorros.Add(new Cuenta_Ahorro {  Interes = 12, Numero = 42423, Saldo = 45424, Titular = "Miguel Toño", Vencimiento = Convert.ToDateTime("24/07/2024") });
            return ahorros;
        }

        //Aqui se crea la lista de datos de la clase Cuenta corriente
        public List<Cuenta_Corriente> Corrientes()
        {
            List<Cuenta_Corriente> corrientes = new List<Cuenta_Corriente>();
            corrientes.Add(new Cuenta_Corriente { Interes = 11, Numero = 12345, Saldo = 453545.654, Titular = "Miguel Toño" });
            corrientes.Add(new Cuenta_Corriente { Interes = 13, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño" });
            corrientes.Add(new Cuenta_Corriente { Interes = 34, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño" });
            corrientes.Add(new Cuenta_Corriente { Interes = 12, Numero = 42323, Saldo = 45454, Titular = "Miguel Toño" });
            corrientes.Add(new Cuenta_Corriente { Interes = 12, Numero = 42423, Saldo = 45424, Titular = "Miguel Toño" });
            return corrientes;
        }

    }
}
