using System.Linq;

namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            string info = "";
            do
            {
                // kasutajalt info saamine
                Console.WriteLine("Palun sisesta filtreeritav lähteinfo");
                info = GetResponse();
                Console.WriteLine("Palun sisesta otsitav info: ");
                string SearchThisWord = GetResponse();
                // filtreerimine
                bool DoesWordExist = FindThisWord(SearchThisWord, info);
                if (DoesWordExist == true)
                {
                    Console.WriteLine("Leidsime sõna \"" + SearchThisWord + "\" sinu sisestatud infost:");
                    Console.WriteLine(info);
                }
                else
                {
                    Console.WriteLine("Sõna\"" + SearchThisWord + "\"infost puudub");
                }
                // programmi töö kordamine
                vastus = RepeatAction();
            } while (vastus == "jah");
            vastus = "";

            do
            {
                Console.WriteLine("Kas soovid infosse midagi juurde lisada? (jah/ei)");
                vastus = GetResponse();
                if (vastus == "jah")
                {
                    Console.WriteLine("Kirjuta juurdelisatav info: ");
                    info += GetResponse();
                }
                vastus = RepeatAction();

            } while (vastus == "jah");

            do
            {
                Console.WriteLine("Kas salvestad dokumendi töölauale, või dokumendikausta?");
                string kuhu = GetResponse();

                string savefilehere = "";
                if (kuhu == "töölaud")
                {
                    savefilehere = "C:\\Users\\opilane\\Desktop\\info.txt";
                    File.WriteAllText(savefilehere, info);
                }
                else if (kuhu == "dokumendid")
                {
                    savefilehere = "C:\\Users\\opilane\\Documents\\info.txt";
                    File.WriteAllText(savefilehere, info);
                }
                else
                {
                    Console.WriteLine("Ei saa aru, " + kuhu + " ei ole salvestatav asukoht");
                    vastus = RepeatAction();
                }
            } while (vastus == "jah");

            // programmi lõpp
            Console.WriteLine("Headaega");
        }
        private static string RepeatAction()
        {
            string vastus;
            Console.WriteLine("Kas tahad tegevust korrata? (jah/ei)");
            vastus = GetResponse();
            return vastus;
        }

        public static bool FindThisWord(string filter, string ToBeFiltered)
        {
            if (ToBeFiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();
            }
            return sisestus;
        }
    }
}
