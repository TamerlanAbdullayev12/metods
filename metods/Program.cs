using System;
using System.Text;

namespace metods
{
    class Program
    {
        static void Main(string[] args)
        {
            ////methods task    1



            //Console.WriteLine("tam eded daxil edin");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2ci tam ededi daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //int cem = Toplama(num, num2);
            //Console.WriteLine(cem);


            ////methods task    3

            //Console.WriteLine("ededi daxil edin");
            //float numberr=float.Parse(Console.ReadLine());
            //float yuvarlaqeded=Yuvarla(numberr);
            //Console.WriteLine(yuvarlaqeded);

            ////methods task    4


            //Console.WriteLine("tam eded daaxil edin");
            //int numm = int.Parse(Console.ReadLine());
            //Tekdir(numm);


            ////methods task    5

            //Console.WriteLine("true false daxil edin");
            //bool truefalse = bool.Parse(Console.ReadLine());
            //Bx(truefalse);

            ////methods task    6


            //Console.WriteLine("enter name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter surname");
            //string surname = Console.ReadLine();
            //Namesurname(name, surname);


            ////methods task    7

            //Console.WriteLine("eded daxil edin");
            //decimal nummm = decimal.Parse(Console.ReadLine());
            //Kvadrat(nummm);


            ////methods task    8


            //Console.WriteLine("eded daxil edin");
            //int numbr = int.Parse(Console.ReadLine());
            //bool truuu= true;
            //for (int i = 2; i < numbr; i++)
            //{
            //    if (numbr % i == 0)
            //    {
            //        truuu = true;
            //        break;
            //    }
            //    else
            //        truuu = false;
            //}

            //Print(truuu);


            ////methods task     9

            //Console.WriteLine("ededi daxil edin");
            //int numberrr = int.Parse(Console.ReadLine());
            //Console.WriteLine("ededin quvvetini daxil edin");
            //int power = int.Parse(Console.ReadLine());
            //int quvvet = Quvvet(numberrr, power);
            //Console.WriteLine(quvvet);
        }

        static int Toplama(int num, int num2)
        {
            return num + num2;
        }
        static float Yuvarla(float numberr)
        {
            if (numberr % 1 >= 0.5)
                numberr = (int)numberr + 1;
            else
                numberr = (int)numberr;
            return numberr;
        }
        static void Tekdir(int numm)
        {
            bool a = default;
            if (numm % 2 == 0)
                a = false;
            else
                a = true;
            Console.WriteLine(a);
        }
        static void Bx(bool truefalse)
        {
            if (truefalse == true)
                Console.WriteLine("beli");
            else
                Console.WriteLine("xeyr");
        }
        static void Namesurname(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }
        static void Kvadrat(decimal nummm)
        {
            Console.WriteLine(nummm *= nummm);
        }
        static void Print(bool truuu)
        {
            if (truuu)
                Console.WriteLine("eded sade deyil");
            else
                Console.WriteLine("eded sadedir");
        }
        static int Quvvet(int numberrr, int power)
        {
            int quvvet = 1;
            for (int i = 0; i < power; i++)
                quvvet *= numberrr;
            return quvvet;
        }
    }
}
