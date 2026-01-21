namespace Meetodid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm?");
            string lemmikfilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikfilm);
            filmid = DoYouLikeThisMovie(filmid, "Predator: Badlands 2025");
            //foreach (string item in filmid)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static List<string> DoYouLikeThisMovie(List <string> collection, string movieToAdd)
        {
            if (collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldib {movieToAdd}?");
                string vastus = ReadAnswer();

                if (vastus == "Jah")
                {
                    collection.Add(movieToAdd);
                    Console.WriteLine("Lisasin filmi sulle");
                }
                else
                {
                    Console.WriteLine("Aga miks? See on ju hea film");
                }
            }
            return collection;
        }


        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach (var item in collection)
            {
                if (item == findThis)
                {
                    itExists = true;
                }
            }
            if (itExists == true )
            {
                Console.WriteLine("Näe mäletasid ikka!");
            }
            else
            {
                Console.WriteLine("A kus sinu lemmikfilm?");
            }

        }

        public static string ReadAnswer()
        {
            string sisend = "";
            while (sisend == "")
            {
                sisend = Console.ReadLine();
            }
            return sisend;
        }


        public static List<string> GetMovies()
        {
            Console.WriteLine("Mis on siu lemmikfilmid, sisesta ükshaaval, kui sisestada rohkem ei taha\nsisesta \"ei ole\" ");
            string sisestus = "";
            List <string> siinOnFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.WriteLine("Järgmine film:");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    siinOnFilmid.Add(sisestus);
                }
            }
            return siinOnFilmid;
        }
        
    }
}
