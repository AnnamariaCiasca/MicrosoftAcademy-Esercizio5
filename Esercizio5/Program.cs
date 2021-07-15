//Morra Cinese (carta forbice sasso)

//Stampare un messaggio di benvenuto al gioco Morra Cinese.
//Chiedere il NOME dell'utente quindi stampare un messaggio del tipo "Ok NOME, iniziamo a giocare".
//Il computer sceglie (in modo random) una tra le possibili opzioni tra carta, sasso o forbice.
//Avvisa l'utente che ha effettuato la sua scelta quindi invita l'utente a fare lo stesso cioè
//a scegliere una delle 3 opzioni tra quelle disponibili per poter giocare contro di lui.

//Dopo la scelta dell'utente sarà quindi "calcolato" il vincitore in base al confronto tra le opzioni scelte.
//Stampare a video un messaggio all'utente che dica se ha vinto, ha perso oppure c'è stato un pareggio.


//Ricordiamo che:
//Sasso vince su Forbice
//Carta vince su Sasso
//Forbice vince su Carta


//Al termine del gioco si richiede all'utente se desidera giocare ancora contro il computer.
//In caso affermativo si ricomincia a giocare,
//altrimenti si esce dal gioco e deve essere mostrato un messaggio di arrivederci.



using System;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {

            char continua;
            int sceltaComputer = 0;
            int sceltaGiocatore = 0;
            
            String sceltaComputerFinale = "";
            String sceltaGiocatoreFinale = "";

            Console.WriteLine("Benvenuto nel gioco Morra Cinese!");
            Console.WriteLine("\nCome ti chiami?");

            do
            {
                String nome = Console.ReadLine();
                Console.WriteLine($"Ok {nome}, iniziamo a giocare!");



                TurnoComputer(ref sceltaComputer, ref sceltaComputerFinale);

                Console.WriteLine("\nIo ho scelto, ora tocca a te!\n");

                TurnoGiocatore(ref sceltaGiocatore, ref sceltaGiocatoreFinale);


                Console.WriteLine($"\nHai scelto {sceltaGiocatoreFinale}!");

                Console.WriteLine($"Io ho scelto {sceltaComputerFinale}");

                Verifica(ref sceltaComputerFinale, ref sceltaGiocatoreFinale);
             
                
                Console.WriteLine("\nContinuare? s/n\n");
                continua = Console.ReadKey().KeyChar;

        } while (continua == 's' || continua == 'S');
        

}

        private static void Verifica(ref string sceltaComputerFinale, ref string sceltaGiocatoreFinale){
            
            if (sceltaGiocatoreFinale == "sasso" && sceltaComputerFinale == "forbici" || sceltaGiocatoreFinale == "carta" && sceltaComputerFinale == "sasso" || sceltaGiocatoreFinale == "forbici" && sceltaComputerFinale == "carta")
            {
                Console.WriteLine("\nComplimenti, hai vinto!");
            }
            else if (sceltaGiocatoreFinale == "forbici" && sceltaComputerFinale == "sasso" || sceltaGiocatoreFinale == "sasso" && sceltaComputerFinale == "carta" || sceltaGiocatoreFinale == "carta" && sceltaComputerFinale == "forbici")
            {
                Console.WriteLine("\nPeccato, hai perso!");
            }
            else if(sceltaGiocatoreFinale == "forbici" && sceltaComputerFinale == "forbici" || sceltaGiocatoreFinale == "sasso" && sceltaComputerFinale == "sasso" || sceltaGiocatoreFinale == "carta" && sceltaComputerFinale == "carta")
            {
                Console.WriteLine("\nPareggio!");
            }
        }

        private static void TurnoGiocatore(ref int sceltaGiocatore, ref string sceltaGiocatoreFinale)
        {
            Console.WriteLine("Cosa scegli?\n" +
              "\n1) sasso" +
              "\n2) carta" +
              "\n3) forbici\n");

            sceltaGiocatore = int.Parse(Console.ReadLine());

            switch (sceltaGiocatore)
            {
                case 1:
                    sceltaGiocatoreFinale = "sasso";
                    break;
                case 2:
                    sceltaGiocatoreFinale = "carta";
                    break;
                case 3:
                    sceltaGiocatoreFinale = "forbici";
                    break;
                default:
                    Console.WriteLine("Valore scelto non corretto");
                    break;

            }

        }

        private static void TurnoComputer(ref int sceltaComputer, ref string sceltaComputerFinale)
        {

            Random gen = new Random();
            sceltaComputer = gen.Next(1, 4);
            switch (sceltaComputer)
            {
                case 1:
                    sceltaComputerFinale = "sasso";
                    break;
                case 2:
                    sceltaComputerFinale = "carta";
                    break;
                default:
                    sceltaComputerFinale = "forbici";
                    break;

            }

        }
    }
}
