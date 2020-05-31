using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Zadani
/* By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number? */
namespace eul7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte maximalni hodnotu pro hledani prvocisel.");
            int maximum= Convert.ToInt32(Console.ReadLine());
            //pocitadlo prvocisel, zacina na jedna, protoze uz tam ma dvojku
            int pctPrv = 2;
            //list pro nalezena prvocisla
            List<int> primes = new List<int>();
            bool isPrime;
            for(int cntr=2;cntr<=maximum ;cntr++)
            {
                //prve budeme cislu verit, ze je prvocislo, dokud nas nepresvedci o opaku
                isPrime = true;
                //pokud je delitelne dvema neni prvocislo (jedine delitelne 2 je 2)
                if (cntr % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    //zkousej delit prvocisly, ktere zname, pokud neni delitelne zadnym, tak je to prvocislo
                    foreach (int prvocislo in primes)
                    {
                        //je delitelne prvocislem, tedy neni prvocislo samo
                        if (cntr % prvocislo == 0)
                        {
                            isPrime = false;
                            break;
                        }


                    }
                }
                //pokud jsme nedokazali vyvratit, ze je cislo prvocislo, budeme mu verit a zvysime pocet, plus ho pridame do seznamu prvocisel
                if (isPrime == true && pctPrv == 10001)
                {
                    Console.WriteLine(cntr);
                }
                if(isPrime==true)
                {
                    Console.WriteLine("{0}.prvocislo je: {1}",pctPrv,cntr);
                    //zvysi pocitadlo
                    pctPrv++;
                    //prida cislo do listu prvocisel
                    primes.Add(cntr);
                }
            }
            Console.WriteLine("Od 0 do {0} jsem nasel {1} prvocisel.", maximum, pctPrv);
            Console.ReadLine();

        }
    }
}
