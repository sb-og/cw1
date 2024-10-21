/*
1. Wymień i opisz podstawowe elementy struktury programu w C#, takie jak: namespace, 
class, Main oraz instrukcje using. Opisz ich rolę w programie.
*/
using System;
using System.Linq.Expressions;
using Microsoft.VisualBasic; //instrukcja using pozwala na zaimportowanie zewnętrzych bibliotek z których kodu będzie mógł korzystać nasz program

namespace cwiczenia // Przestrzeń nazw dla zmiennych klas i innych typów danych, by uniknąć konfliktów
{
    class Program //Klasy pozwalają na definiowanie obiektów, są podstawową strukturą programowania obiektowego
    {
        static void clear()
        {
            Console.WriteLine("Kliknij dowolny przycisk by kontynuować");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args) //Główna funkcja wykonywana przez program
        {


            //zad_2_do_13();
            zad_14();
            zad_15();


            void zad_2_do_13()
            {
                /*
                2. Wypisz na konsoli tekst „Hello World” za pomocą polecenia Console.Write() następnie 
                dopisz do tej samej linii w programie „to jest mój pierwszy program”.
                */
                Console.WriteLine("Hello, World! (To nie jest mój pierwszy program ;)");

                /*
                3. Wyjaśnij różnicę pomiędzy działaniem Console.Write(), a Console.WriteLine(). Czy 
                wielkość liter w komendach Console.Write() oraz Console.WriteLine() ma znaczenie? 
                Czy Console.write() to poprawna dyrektywa?
                */
                Console.Write("Console write nie przełamuje linii, To jest - ");
                Console.WriteLine("ciąg dalszy pierwszej linii");
                Console.WriteLine("To jest nowa linia");

                /*
                4. Wypisz na konsoli tekst „Hello World” za pomocą polecenia Console.Write() następnie 
                wstaw za pomocą Console.Write() znak specjalny:
                a) Spację 
                b) Enter 
                c) Tablulator
                */
                Console.Write("Hello World");
                Console.Write($" ."); //spacja.
                Console.Write(@"
                .");//enter lub "/n" (escape sequence). 
                Console.Write($" .");//tabulator "/t".
                Console.WriteLine();

                /*
                5. Sprawdź wynik działania programu 
                Console.WriteLine("tekst" == "tekst"); 
                Console.WriteLine("K" == "k"); 
                Console.WriteLine(1 == 4); 
                string myValue = "K"; 
                Console.WriteLine(myValue == "K");
                Sprawdź działanie programu 
                Console.WriteLine(1 > 5); 
                Console.WriteLine(1 < 5); 
                Console.WriteLine(1 >= 5); 
                Console.WriteLine(1 <= 5);
                */
                Console.WriteLine("tekst" == "tekst"); //True
                Console.WriteLine("K" == "k"); //False
                Console.WriteLine(1 == 4); //False
                string myValue = "K";
                Console.WriteLine(myValue == "K"); //True
                Console.WriteLine(1 > 5); //False
                Console.WriteLine(1 < 5); //True
                Console.WriteLine(1 >= 5); //False
                Console.WriteLine(1 <= 5); //True

                /*
                6. Przeanalizuj i wyjaśnij działanie poniższego kodu:
                string test= "Moj pierwszy program"; 
                Console.WriteLine(test.Substring(4, 2));
                */
                string test = "Moj pierwszy program";
                Console.WriteLine(test.Substring(4, 2)); // wydziela ciąg znaków będący częścią oryginalnego ciągu ze zmiennej test (pomija 4 znaki po czym przepisuje dwa i pomija resztę)

                /*
                7. Przeanalizuj działanie poniższego kodu a) oraz b) 
                a) int mojWiek = 50; 
                int twojWiek = mojWiek > 40? 40 : 20;
                Console.WriteLine($"Twój Wiek: {twojWiek}"); 
                Następnie sprobuj skompilować i przetestować poniższy kod:
                */
                int mojWiek = 41;
                int twojWiek = mojWiek < 40 ? 40 : 20; //jeżeli mojWiek < 40 to przypisz 40 do zmiennej twojWiek, jeśli nie przypisz 20
                Console.WriteLine($"Twój Wiek: {twojWiek}");


                /*
                8. Zapisz w raporcie poszczególne liczby, które są zapisane w systemie liczb dziesiętnych:
                a) W systemie ósemkowym
                b) W systemie szesnastkowym
                c) W systemie binarnym
                0, 4, 256, 1024, 10, 100, 1, 50, 20, 64

                odpowiedz:
                a) 0, 4, 400, 2000, 12, 144, 1, 62, 24, 100
                b) 0, 4, 100, 400, A, 64, 1, 32, 14, 40
                c) 0, 100, 100000000, 10000000000, 1010, 1100100, 1, 110010, 10100, 1000000
                */

                /*
                9. Sprawdź czy podane nazwy zmiennych są dozwolone w języku C#
                double Tmp;
                double $tmp; //znak specjalny nie moze byc w nazwie zmiennej
                float tmp’; //znak specjalny nie moze byc w nazwie zmiennej
                string 3tm; //liczba nie może być na początku nazwy zmiennej
                char _tmp;
                int mojNumer = 5;
                int _mojNumer = 5;
                int 5mojNumer = 5; //liczba nie może być na początku nazwy zmiennej
                int moj Numer = 5; //nazwa zmiennej nie moze miec spacji
                int %mojNumer = 5; //znak specjalny nie moze byc w nazwie zmiennej
                int MojNumer = 5;
                */
                /*
                10. Czy w programie mogą istnieć zmienne o nazwach
                int testvar=8 oraz int Testvar=8. 
                */
                int testvar = 8;
                int testVar = 1;
                Console.WriteLine("czy obie te zmienne mogą istnieć jednocześnie? - " + (!testvar.Equals(testVar))); //obie te zmienne mogą istnieć jednocześnie

                /*
                11. Wypisz na konsoli tekst, który pobierze z systemu i wyświetli dzisiejszą datę za pomocą 
                polecenia Console.WriteLine(). 
                Wykorzystaj funkcję: DateTime dzisiejszaData = DateTime.Now;
                */
                Console.WriteLine(DateTime.Now);


                /*
                12. Napisz program, który pobierze od użytkownika kolejno całe linie z danymi osobowymi:
                a) Rok urodzenia
                b) Imię i Nazwisko
                c) Wiek
                d) Miejsce Urodzenia
                Następnie wyświetl dane z podpunktu a) b) c) oraz d) w jednej linii.
                Wyjaśnij krótko różnice pomiędzy metodami Console.Write(), a Console.WriteLine()
                */

                clear();

                Console.WriteLine("Podaj Rok urodzenia: ");
                string birthYear = Console.ReadLine();
                Console.WriteLine("Podaj imię: ");
                string name = Console.ReadLine();
                Console.WriteLine("Podaj Nazwisko: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Podaj wiek: ");
                string age = Console.ReadLine();
                Console.WriteLine("Podaj miejsce urodzenia: ");
                string birthPlace = Console.ReadLine();

                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine($"Rok urodzenia: {birthYear}, Imię: {name}, Nazwisko: {surname}, Wiek: {age}, Miejsce urodzenia: {birthPlace}");
                /*
                13. Korzystając z funkcji sizeof przypisz i wyświetl rozmiary za pomocą zmiennej 
                „int rozmiar” dla poszczególnych typów danych
                a) Float
                b) Char
                c) Double
                d) Int
                */
                clear();
                int rozmiarFloat = sizeof(float);
                int rozmiarChar = sizeof(char);
                int rozmiarDouble = sizeof(double);
                int rozmiarInt = sizeof(int);

                Console.WriteLine($"float: {rozmiarFloat}, char: {rozmiarChar}, double: {rozmiarDouble}, int: {rozmiarInt} ");
                clear();
            }


            void zad_14()
            {
                /*
                14. Napisz program, który pobierze od użytkownika dowolną liczbę nieparzystą, która będzie 
                oznaczać wiek, a następnie przypisze te wartość trzykrotnie do zmiennych:
                a) int wiek;
                b) double wiek;
                c) float wiek;
                */
                string wiek = "";
                int? wiek1 = null;
                double? wiek2 = null;
                float? wiek3 = null;

                bool idOdd(double? x)
                {
                    if ((x % 2 == 0) || (x == 0) || x == null) return false;
                    else return true;
                }

                do
                {
                    try
                    {
                        Console.WriteLine("Podaj liczbę nieparzystą");
                        wiek = Console.ReadLine();
                        wiek1 = int.Parse(wiek);
                        wiek2 = double.Parse(wiek);
                        wiek3 = float.Parse(wiek);

                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Błąd - proszę wprowadzić wartość liczbową");
                        Thread.Sleep(1000);
                        zad_14();
                    }
                }
                while (!idOdd(wiek2));
                Console.WriteLine("Podałeś poprawną liczbę nieparzystą");
                clear();
            }

            void zad_15()
            {
                /*
                15. Napisz program, który pobierze od użytkownika dowolną liczbę w systemie binarnym 
                i zamieni ją na liczbę w systemie dziesiętnym
                */
                Console.WriteLine("Podaj liczbę binarną: ");
                string input = Console.ReadLine();
                try
                {
                    double wynik = 0;
                    int potega = input.Length;
                    for (int i = 0; i < input.Length; i++)
                    {
                        char[] znaki = input.ToCharArray();
                        int pozycja = int.Parse(znaki[i].ToString());
                        if (!((pozycja == 1) || (pozycja == 0))) throw new Exception();
                        double skladowa = pozycja * Math.Pow(2, --potega);
                        //Console.WriteLine($"debug: {znaki[i]} -- {skladowa}");
                        wynik += skladowa;
                    }
                    Console.WriteLine($"Liczba w zapisie dziesiętnym {wynik}");
                    Thread.Sleep(1000);
                    clear();
                    zad_15();
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Spróbuj ponownie ");
                    Thread.Sleep(1000);
                    clear();
                    zad_15();

                }

            }
        }
    }

}