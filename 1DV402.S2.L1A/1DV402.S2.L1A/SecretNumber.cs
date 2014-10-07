using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {

        /// <summary>
        /// Publik metod som initierar klassens fält.
        ///• _number ska tilldelas ett slumpat heltal i det slutna intervallet mellan 1 och 100. 
        ///• _count ska tilldelas värdet 0.
        /// </summary>
        public void Initialize()
        {

        }

        //Privat fält som räknar antalet gjorda gissningar sedan det hemliga talet slumpades fram. 
        private int _count = 0;

        //Privat fält som innehåller det hemliga talet.
        static Random rnd = new Random();
        private int _number = rnd.Next(1, 100);



        /// <summary>
        ///Publik konstant med värdet 7 som definierar hur många gissningar en användare har på sig att gissa 
        ///rätt.
        /// </summary>
        public const int MaxNumberOfGuesses = 7;



        /// <summary>
        ///Publik metod som anropas för att göra en gissning av det hemliga talet. Beroende om det gissade talets 
        ///värde, som parametern number innehåller, är för högt, lågt eller överensstämmer med det hemliga talet 
        ///ska lämpliga meddelanden, innehållande det gissade värde samt antalet kvarstående gissningar, skrivas 
        ///ut.
        ///Om den sjunde gissningen görs och är felaktig ska användaren meddelas att det inte är några 
        ///gissningar kvar och vilket det hemliga talet var.11
        ///Anropas metoden MakeGuess() fler än sju gånger efter varandra innan ett nytt hemligt tal har 
        ///slumpats fram, genom ett anrop av metoden Initialize(), ska metoden MakeGuess() kasta ett 
        ///undantag av typen ApplicationException.
        ///Om det vid anrop av metoden MakeGuess() skickas med ett argument som inte är i det slutna 
        ///intervallet mellan 1 och 100 ska metoden, efter att undersökt parameterns värde, kasta ett undantag av 
        ///typen ArgumentOutRangeException.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool MakeGuess(int number)
            
        {

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
