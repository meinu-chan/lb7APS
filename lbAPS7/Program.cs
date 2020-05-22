using System;

namespace lbAPS7
{
    class Program
    {
        static void Main(string[] args)
        {
            var brecipiet = new BankRecipient();
            var bsender = new BankSender();

            Console.WriteLine("\t\tPlease, choose the Bank\n\t1.Western Union; \t\t2.Swift\nTip:just press 1 or 2");
            
            int n = int.Parse(Console.ReadLine());
            
            if (n == 1)
            {
                var westU = new WestUnionHandler();

                Client.CustomerCode(westU);
                westU.SetNext(bsender).SetNext(brecipiet);
            }
            else if (n == 2)
            {
                var swift = new SwiftHandler();

                Client.CustomerCode(swift);
                swift.SetNext(bsender).SetNext(brecipiet);
            }
            else
                Console.WriteLine("Choose number from 1 to 2");
        }
    }
}
