using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.View
{
    public class SaveUserView
    {
        public InputData RequestData()
        {
            return this.Show();
        }

        private InputData Show()
        {
            InputData input = new InputData();
            Console.WriteLine("======================================");
            Console.WriteLine("1. Ingrese el nuevo codigo del socio: ");
            input.fields.Add("CodigoSocio", Console.ReadLine());
            Console.WriteLine("2. Ingrese el nombre del socio: ");
            input.fields.Add("FirstName", Console.ReadLine());
            Console.WriteLine("3. Ingrese el apellido del socio: ");
            input.fields.Add("SecodName", Console.ReadLine());
            return input;
        }
    }
}
