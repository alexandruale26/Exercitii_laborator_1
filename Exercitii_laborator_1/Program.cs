using System;

namespace Exercitii_laborator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            //Ex10();
        }

        static void Ex1()
        {
            // Scrieti un program care citind de la tastaura cele trei dimensiuni
            // ale unui paralelipiped dreptunghic , va afisa volumul lui

            Console.WriteLine("Introduceti lungimea laturei 1");
            int latura1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea laturei 2:");
            int latura2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea laturei 3:");
            int latura3 = int.Parse(Console.ReadLine());

            int volum = latura1 * latura2 * latura3;
            Console.WriteLine($"Volumul paralelipipedului dreptunghic este -->  {volum}");
        }

        static void Ex2()
        {
            // Scrieti un program care va calcula media aritmetica
            // a trei numere citite de la tastatura

            Console.WriteLine("Introduceti primul numar");
            double numar1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            double numar2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            double numar3 = double.Parse(Console.ReadLine());

            double mediaAritmetica = (numar1 + numar2 + numar3) / 3;
            Console.WriteLine($"Media aritmetica este -->   {mediaAritmetica}");
        }

        static void Ex3()
        {
            // Scrieti un program care va afisa ultima cifra
            // a unui numar intreg citit de la tastatura

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            int ultimaCifra = numar % 10;
            Console.WriteLine($"Ultima cifra a numarului este ->   {ultimaCifra}");

        }

        static void Ex4()
        {
            /* Scrieti un program care va afisa semnul unui numar citit de la tastatura
               Daca numarul este pozitiv, va afisa +
               Daca numarul este negativ, va afisa -
               Daca numarul este 0, va afisa 0 
            */

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            if (numar > 0) Console.WriteLine("+");
            else if (numar < 0) Console.WriteLine("-");
            else Console.WriteLine("0");
        }

        static void Ex5()
        {
            /* Se citesc doua numere de la tastatura, x, y.
               Scrieti un program care va afisa cele doua valori in ordine crescatoare.
               Exemplu: citim 9,0. Afisam: 0, 9. 
            */

            Console.WriteLine("Introduceti primul numar");
            int numarul1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int numarul2 = int.Parse(Console.ReadLine());

            if (numarul1 < numarul2) Console.WriteLine($"{numarul1}   {numarul2}");
            else if (numarul2 < numarul1) Console.WriteLine($"{numarul2}   {numarul1}");
        }

        static void Ex6()
        {
            /* Se citesc trei numere de la tastatura: x,y,z. 
               Scrieti un program care va afisa cele trei valori in ordinedes crescatoare.
               Exemplu : citim 3,9,0 Afisam : 9 3 0.
            */

            int pos1 = 0, pos2 = 0, pos3 = 0;
            int[] val = new int[3];

            Console.WriteLine("Introduceti primul numar");
            val[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            val[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");
            val[2] = int.Parse(Console.ReadLine());

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] > pos1)
                {
                    pos3 = pos2;
                    pos2 = pos1;
                    pos1 = val[i];
                }
                else if (val[i] < pos1 && val[i] < pos2)
                {
                    pos3 = val[i];
                }
                else if (val[i] < pos1)
                {
                    pos3 = pos2;
                    pos2 = val[i];
                }
            }

            Console.WriteLine("Numerele asezate descrescator:");
            Console.WriteLine($"{pos1}   {pos2}   {pos3}");
        }

        static void Ex7()
        {
            // Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
            // impar. In cazul in care numarul este par, programul va afisa “par” iar in caz contrar impar.

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            if (numar % 2 == 0) Console.WriteLine($"Numarul {numar} este par");
            else Console.WriteLine($"Numarul {numar} este impar");
        }

        static void Ex8()
        {
            /* Se citesc doua numere de la tastatura, x si y. Scrieti un program care 
               va verifica daca x este divizibil cu y. In cazul in care x este divizibil cu y, 
               programul va afisa divizibil ” iar in caz contrar "indivizibil".
            */

            Console.WriteLine("Introduceti primul numar");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0) Console.WriteLine("Divizibil");
            else Console.WriteLine("Indivizibil");
        }

        static void Ex9()
        {
            // Scrieti un program care interschimba valoarea a doua variabile intregi

            Console.WriteLine("Introduceti x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti y");
            int y = int.Parse(Console.ReadLine());

            int middleMan;

            middleMan = x;
            x = y;
            y = middleMan;

            Console.WriteLine($"Noile valori: x = {x} si y = {y}");
        }

        static void Ex10()
        {
            // Scrieti un program care va afisa suma cifrelor unui numar 
            // intreg citit de la tastatura. Numarul are exact 2 cifre.

            Console.WriteLine("Introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            int suma = 0;

            while (numar!= 0)
            {
                suma += numar % 10;
                numar /= 10;
            }

            Console.WriteLine($"Suma cifrelor unui numar este  -> {suma}");
            
            

            
        }
    }
}
