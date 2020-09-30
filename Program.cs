using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace ConsoleAppNasledovanie_1
{ 
        class Program
        {
            static void Main(string[] args)
            {
                Student st1 = new Student("", 0, 0);
                Student st2 = new Student("", 0, 0);
                Student st3 = new Student("", 0, 0);

                ArrayList stud = new ArrayList();
                    stud.Add(st1);
                    stud.Add(st2);
                    stud.Add(st3);
                Aspirant asp1 = new Aspirant("", 0, 0, "");
                Aspirant asp2 = new Aspirant("", 0, 0, "");
                Aspirant asp3 = new Aspirant("", 0, 0, "");

                ArrayList list = new ArrayList 
                {
                    asp1,
                    asp2,
                    asp3 
                };

                 stud.Reverse();
                 Console.WriteLine("   ArrayList(reverse) студенты :");
                 foreach (object num in stud)
                 {
                    Student x = (Student)num;
                   Console.WriteLine("имя  : " + x.Lastname +"\nкурс : " + x.Kurs +   "\nномер: "+ x.Zacetka+"\n    ");
                 }

                 Console.WriteLine("    ArrayList аспиранты :");
                 foreach (object num in list)
                 {
                     Aspirant x = (Aspirant)num;
                     Console.WriteLine("имя  : " + x.Lastname + "\nкурс : " + x.Kurs + "\nномер: " + x.Zacetka +"\nтема : "+x.Tema + "\n    ");
                 }

                    Console.WriteLine("   Linkedlist студент :");
                    LinkedList<string> student = new LinkedList<string>();
                   student.AddFirst(st1.Lastname);
                   student.AddAfter(student.First, st1.Zacetka.ToString());
                   student.AddLast(st1.Kurs.ToString());
                   foreach (string i in student)
                   {
                        Console.WriteLine(i);
                   }


                    Dictionary<char, Student> people = new Dictionary<char, Student>();

                    people.Add('a', new Student() { Lastname = st1.Lastname, Kurs = st1.Kurs, Zacetka = st1.Zacetka });

                    people.Add('b', new Student() { Lastname = st2.Lastname, Kurs = st2.Kurs, Zacetka = st2.Zacetka });

                    people.Add('c', new Student() { Lastname = st3.Lastname, Kurs = st3.Kurs, Zacetka = st3.Zacetka });
                     Console.WriteLine("    Dictionary студенты :");
                 foreach (KeyValuePair<char, Student> keyValue in people)
                 { 
                     Console.WriteLine("ключ :" + keyValue.Key + "\nимя  :" + keyValue.Value.Lastname + "\nкурс :" + keyValue.Value.Kurs + "\nномер:" + keyValue.Value.Zacetka);
                 }
            }
        }
        abstract class Human
        {
            public Human()
            {

            }
            public string Lastname { get; set; }
            public int Kurs { get; set; }
            public int Zacetka { get; set; }

            public Human(string lastname, int kurs, int zacetka)
            {
                Lastname = lastname;
                Kurs = kurs;
                Zacetka = zacetka;

            }
            public abstract void Print();
            public abstract int ValidKurs();
            public abstract int Validnum();
        }

        class Student : Human
        {
                public Student()
                {

                }
            public Student(string lastname, int kurs, int zacetka) : base(lastname, kurs, zacetka)
            {

                Console.WriteLine("введите имя студента");
                Lastname = Console.ReadLine();
                Console.WriteLine("введите курс(1-9)");
                Kurs = ValidKurs();
                Console.WriteLine("введите номер №000");
                Zacetka = Validnum();
            }

            public override void Print()
            {
                Console.WriteLine($"студент :{Lastname}\nна :{Kurs} курсе \nномер зачетной книжки :{Zacetka}");
            }
            public override int ValidKurs()
            {
                int num1;
                bool triger = false;
                do
                {

                    if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 10)
                    {
                        triger = true;
                    }
                    else
                    {
                        Console.WriteLine("вы ввели неверное число");
                        continue;
                    }
                }
                while (triger == false);
                return num1;
            }
            public override int Validnum()
            {
                int num1;
                bool triger = false;
                do
                {

                    if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 999)
                    {
                        triger = true;
                    }
                    else
                    {
                        Console.WriteLine("вы ввели неверное число");
                        continue;
                    }
                }
                while (triger == false);
                return num1;
            }
            public override string ToString()
            {
                if (String.IsNullOrEmpty(Lastname))
                    return base.ToString();
                return Lastname;
            }

        }
        class Aspirant : Human
        {
            private string tema;

            public Aspirant(string lastname, int kurs, int zacetka, string tema) : base(lastname, kurs, zacetka)
            {
                this.Tema = tema;
                Console.WriteLine("введите имя аспиранта");
                Lastname = Validstring();
                Console.WriteLine("введите курс(1-9)");
                Kurs = ValidKurs();
                Console.WriteLine("введите номер книжки(№000)");
                Zacetka = Validnum();
                Console.WriteLine("введите тему");
                Tema = Validstring();
            }
            public string Tema
            {
                get { return tema; }
                set { tema = value; }
            }
            public override void Print()
            {


                Console.WriteLine($"аспирант :{Lastname}\nна :{Kurs} курсе \nномер зачетной книжки :{Zacetka}\nтема десертации :{Tema} ");
            }

            public override int ValidKurs()
            {
                int num1;
                bool triger = false;
                do
                {

                    if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 10)
                    {
                        triger = true;
                    }
                    else
                    {
                        Console.WriteLine("вы ввели неверное число");
                        continue;
                    }
                }
                while (triger == false);
                return num1;
            }
            public override int Validnum()
            {
                int num1;
                bool triger = false;
                do
                {

                    if (int.TryParse(Console.ReadLine(), out num1) && num1 > 0 && num1 < 999)
                    {
                        triger = true;
                    }
                    else
                    {
                        Console.WriteLine("вы ввели неверное число");
                        continue;
                    }
                }
                while (triger == false);
                return num1;
            }
            public static string Validstring()
            {
                bool check = true;
                string name;
                do
                {
                    name = Console.ReadLine();
                    foreach (char a in name)
                    {
                        if (a >= '0' && a <= '9')
                        {
                            Console.WriteLine("введите снова");
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                } while (check == false);
                return name;
            }

        }
}

    

