using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.

73167176531330624919225119674426574742355349194934 
96983520312774506326239578318016984801869478851843
85861560789112949495459501737958331952853208805511
12540698747158523863050715693290963295227443043557
66896648950445244523161731856403098711121722383113
62229893423380308135336276614282806444486645238749
30358907296290491560440772390713810515859307960866
70172427121883998797908792274921901699720888093776
65727333001053367881220235421809751254540594752243
52584907711670556013604839586446706324415722155397
53697817977846174064955149290862569321978468622482
83972241375657056057490261407972968652414535100474
82166370484403199890008895243450658541227588666881
16427171479924442928230863465674813919123162824586
17866458359124566529476545682848912883142607690042
24219022671055626321111109370544217506941658960408
07198403850962455444362981230987879927244284909188
84580156166097919133875499200524063689912560717606
05886116467109405077541002256983155200055935729725
71636269561882670428252483600823257530420752963450

Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?*/
namespace eul8
{
    class Program
    {
        class bufferNasobku:Queue<int> 
        {                                 
            public long Pronasob()
            {
                long vysledek = 1;
                if(this.Contains(0))
                {
                    return 0;
                }
                foreach (int nasobek in this)
                {
                    vysledek *= nasobek;
                }
                return vysledek;
            }
        }
        //osklivy hack aby ze StreamReader.read() byl int :(
        static int ToNumber(int a)
        {
            return a - 48;
        }
        static void Main(string[] args)
        {
            long nejvyssiNasobek=1;
            int pocetNasobitelu = 13;
            string souborReseni="euler";
            string filePath = Directory.GetCurrentDirectory() + "\\euler.txt";
            //zjistime, jestli existuje soubor, pokud ne, tak vytvori
            try
            //tady udelat kontrolu/vytvoreni, jestli existuje slozka
            {
                if (!File.Exists(filePath))
                {
                    using(File.CreateText(filePath));
                    Console.WriteLine("Soubor {0} neexistuje, vytvarim...", filePath);
                }
            }
            //chyta chyby pri vytvareni/otvirani souboru
            catch(Exception e)
            {
                Console.WriteLine("Chyba: {0}", e.ToString());
            }
            //ridici struktura
            Console.WriteLine("Zadejte:\na - pro nalezeni reseni\nb - pro upravu parametru\nc - pro vygenerovani nahodneho zadani\nx - pro ukonceni");
            switch (Console.ReadLine())
            {
                case "a":
                    {
                        Console.WriteLine(filePath);
                        //vytvori pole pro nasobitele
                        int[] poleNas=new int[pocetNasobitelu];
                        int[] maxPoleNas = new int[pocetNasobitelu];
                        //int poleNasPozice=0;
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            bufferNasobku current = new bufferNasobku();
                            int nactenyZnak;
                            //cyklus, ktery prochazi cely soubor
                            while (!sr.EndOfStream)
                            {
                                if(sr.Peek()<48)
                                {
                                    Console.Write((char)sr.Read());
                                    continue;
                                }
                                nactenyZnak = (char)sr.Read();
                                Console.Write((char)nactenyZnak);
                                //mame dost cisel pro nasobeni
                                if (current.Count == pocetNasobitelu)
                                {
                                    //jestli je v rade vetsi vysledek nez max, tak vymen
                                    if (current.Pronasob() > nejvyssiNasobek)
                                    {
                                        nejvyssiNasobek = current.Pronasob();
                                    }
                                    current.Dequeue();
                                    current.Enqueue(ToNumber(nactenyZnak));
                                }
                                else
                                {
                                    current.Enqueue(ToNumber(nactenyZnak));
                                }
                            }
                            Console.WriteLine("Nasel jsem nejvyssi nasobek: {0}", nejvyssiNasobek);
                        }
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine(@"Pocet nasobku: {0}\nSoubor matice: {1}", pocetNasobitelu.ToString(),souborReseni);
                        Console.WriteLine(@"Zadejte a - pro zmenu poctu nasobitelu nebo b - pro zmenu souboru matice.");
                        switch (Console.ReadLine())
                        {
                            case "a":
                                {
                                    Console.WriteLine("Zadejte novou hodnotu (int).");
                                    pocetNasobitelu = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                            case "b":
                                {
                                    switch (souborReseni)
                                    {
                                        case "euler":
                                            {
                                                souborReseni = "userInput";
                                                break;
                                            }
                                        case "userInput":
                                            {
                                                souborReseni = "euler";
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    Console.WriteLine("Soubor reseni zmenen na {0}", souborReseni);
                                    break;
                                }

                            default:                               
                                break;
                        }

                        break;
                    }
                case "c":
                    {
                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            Random rnd = new Random();
                            for (int x = 0; x < 1000; x++)
                            {
                                if(x%50==0 && x!=0)
                                {
                                    sw.Write(Environment.NewLine);
                                }
                                sw.Write(rnd.Next(0, 9).ToString());
                            }
                            Console.WriteLine("Vygenerovana nova matice 1000 cisel.");
                        }
                       
                        break;
                    }
                case "x":
                    {
                        return;
                    }

                default:
                    {
                        Console.WriteLine("Nerozumim zadani.");
                        break;
                    }

            }
            //zarazka
            Console.ReadLine();
        }
    }
}
