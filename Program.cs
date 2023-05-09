using Rekrutacja.Context;

namespace Rekrutacja
{
    class Program
    {
        static void Main()
        {
            using (var db = new RekrutacjaContext())
            {
                // Read all użytkownik from database
                var użytkownicy = db.Użytkownicy;

                foreach (var u in użytkownicy)
                {
                    Console.WriteLine($"Imię: {u.Imię}, Nazwisko: {u.Nazwisko}, Email: {u.Email}, Pesel: {u.Pesel}");
                }
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
