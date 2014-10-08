using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //Privat fält som räknar antalet gjorda gissningar sedan det hemliga talet slumpades fram. 
        private int _count;

        //Privat fält som innehåller det hemliga talet.
        private int _number;

        /// <summary>
        ///Publik konstant med värdet 7 som definierar hur många gissningar en användare har på sig att gissa 
        ///rätt.
        /// </summary>
        public const int MaxNumberOfGuesses = 7;

        /// <summary>
        /// Publik metod som initierar klassens fält.
        ///• _number ska tilldelas ett slumpat heltal i det slutna intervallet mellan 1 och 100. 
        ///• _count ska tilldelas värdet 0.
        /// </summary>
        public void Initialize()
        {
            _count = 0;

            Random rnd = new Random();
            _number = rnd.Next(1, 100);
        }

        /// <summary>
        ///Publik metod som anropas för att göra en gissning av det hemliga talet. Beroende om det gissade talets 
        ///värde, som parametern number innehåller, är för högt, lågt eller överensstämmer med det hemliga talet 
        ///ska lämpliga meddelanden, innehållande det gissade värde samt antalet kvarstående gissningar, skrivas 
        ///ut.
        ///
        ///Om den sjunde gissningen görs och är felaktig ska användaren meddelas att det inte är några 
        ///gissningar kvar och vilket det hemliga talet var.
        ///
        ///Anropas metoden MakeGuess() fler än sju gånger efter varandra innan ett nytt hemligt tal har 
        ///slumpats fram, genom ett anrop av metoden Initialize(), ska metoden MakeGuess() kasta ett 
        ///undantag av typen ApplicationException.
        ///
        ///Om det vid anrop av metoden MakeGuess() skickas med ett argument som inte är i det slutna 
        ///intervallet mellan 1 och 100 ska metoden, efter att undersökt parameterns värde, kasta ett undantag av 
        ///typen ArgumentOutRangeException.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool MakeGuess(int number)
        {
            if (_count == MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
            if (_count++ == 7)
            {
                throw new ApplicationException();
            }
            if (1 > number || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number < _number)
            {
                Console.WriteLine("Det hemliga talet är större än {0}. Du har {1} gissning(ar) kvar.", number, MaxNumberOfGuesses - _count);
                return false;
            }
            if (number > _number)
            {
                Console.WriteLine("Det hemliga talet är mindre än {0}. Du har {1} gissning(ar) kvar.", number, MaxNumberOfGuesses - _count);
                return false;
            }
            if (number == _number)
            {
                Console.WriteLine("Grattis, din gissning på tal {0} rätt! Du hade {1} gissning(ar) över.", number, MaxNumberOfGuesses - _count);
                return true;
            }
            return true;
        }

        /// <summary>
        ///Konstruktorn har till uppgift att se till att ett SecretNumber-objekt är korrekt initierat. Det innebär att 
        ///fälten har blivit tilldelade lämpliga värden, vilket enklast görs genom att låta konstruktorn anropa 
        ///metoden Initialize().
        /// </summary>
        public SecretNumber()
        {
            Initialize();
        }
    }
}
