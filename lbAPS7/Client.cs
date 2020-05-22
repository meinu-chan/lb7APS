using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace lbAPS7
{
    class Client
    {
        public static void CustomerCode(AbsHandler handler)
        {
            Console.Write("Enter the amount you want send:");
            var total = Console.ReadLine();
            try
            {
                var res = handler.Handle(float.Parse(total));
                if (res != null)
                    Console.WriteLine($"Recipient will recipe: {res}");
                else
                    Console.WriteLine("Operation Failed, plese try again");
            }
            catch (Exception e)
            {
                Console.WriteLine($"You have : {e}\n Please enter valid numbers!");
            }

        }
    }
}
