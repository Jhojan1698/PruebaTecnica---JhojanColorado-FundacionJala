using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class UserReceivableView
    {
        public InputData RequestData()
        {
            return this.GetData();
        }

        private InputData GetData()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            return input;
        }

        public void ShowResult(int id, string nombres,double cubos, double total)
        {
            Console.WriteLine("R. El consumo del socio ",id," correspondiente a ", nombres,
                              " es de ", cubos, "cubos");
            Console.WriteLine("R. La deuda actual es de: ", total, "Bs");
            Console.WriteLine("======================================");
        }

    }
}
