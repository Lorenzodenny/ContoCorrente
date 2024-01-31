namespace ContoCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somma = 0;
            double media = 0;

            Console.WriteLine("Quanti numeri vuoi inserire");
            int numeroNumeri = int.Parse(Console.ReadLine());
            int[] arrayNumeri = new int[numeroNumeri];
            for (int i = 0; i < numeroNumeri; i++)
            {
                Console.WriteLine($"inserisci il nome {i} ");
                int numero = int.Parse(Console.ReadLine());
                arrayNumeri[i] = numero;

                somma = somma + numero; // cambiamento
            }
            media = somma / numeroNumeri;

            Console.WriteLine($"la somma dei numeri che hai inserito è {somma}");
            Console.WriteLine($" la media è {media}");
        



            return; //inizio esercizio 2
            Console.WriteLine("Quanti nomi vuoi inserire");
            int numeroNomi = int.Parse(Console.ReadLine());
            string[] arrayNomi = new string[numeroNomi];
            for (int i = 0; i < numeroNomi; i++)
            {
                Console.Write($"inserisci il nome {i}: ");
                string nome = Console.ReadLine();
                arrayNomi[i] = nome;
            }

            Console.WriteLine("inserisci il nome che devi metchare");
            string nomeRicercato = Console.ReadLine();
            int contatore = 0;
            string nomeTrovato = "";
            foreach (var nome in arrayNomi)
            {
                if (nomeRicercato == nome)
                {
                    nomeTrovato = nome;
                    contatore++;
                }
            }
            if (contatore > 0)
            {
                Console.WriteLine($"il nome {nomeTrovato} è stato trovato {contatore} volte ");
            }
            else
            {
                Console.WriteLine("il nome non è stato trovato");
            }

        }



            return; // al di sotto primo esercizio
            Console.WriteLine("Benvenuto su Bank");
            Console.Write("inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.Write("inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("inserisci il valore del tuo primo versamento: ");
            int versamento = int.Parse(Console.ReadLine());

            ContoCorrente cashAccount = new ContoCorrente(nome, cognome, versamento);

            bool end = false;

            if(versamento<1000)
            {
                end = true;
                Console.WriteLine("caccia i sordi");
            }

            while(!end)
            {
                Console.WriteLine("Prelievo codice 1");
                Console.WriteLine("Visualizza Saldo codice 2");
                Console.WriteLine("Versamento codice 3");
                Console.WriteLine("Se non vuoi fare altre operazioni codice 4");

                Console.WriteLine("scegli l'opzione");
                string option = Console.ReadLine();
                Console.Clear();
                switch(option)
                {
                    case "1":
                        cashAccount.Prelievo();
                        break;

                    case "2":
                        Console.WriteLine($"il tuo saldo è {cashAccount.Saldo} ");
                        break;

                    case "3":
                        cashAccount.Versamento();
                        break;

                    case "4":
                        end = true;
                        break;

                    default:
                        Console.WriteLine("");
                        break;
                }



            }
        }
    }

    class ContoCorrente
    {
        // FIELDS

        string _nome;
        string _cognome;
        int _idConto;
        int _saldo;

        // PROPREIRTIES

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public int IdCondo
        {
            get
            {
                return _idConto;
            }
            set
            {
                Random random = new Random();
                _idConto = random.Next(100000, 1000000);
            }
        }

        public int Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
         // COSTRUCTOR
        public ContoCorrente(string nome, string cognome, int saldo)
        {
            Nome = nome;
            Cognome = cognome;
            Saldo = saldo;
        }

        // METHODS

        public void Prelievo()
        {
            Console.WriteLine($"Quanto vuoi ritirare? Il tuo conto è: {Saldo}");
            int tot = int.Parse(Console.ReadLine());
            if (tot > Saldo)
            {
                Console.WriteLine("Non hai tutti questi soldini");
            }else if(tot == 0)
            {
                Console.WriteLine("inserisci un importo maggiore di 0");
            }
            else
            {
                Saldo = Saldo - tot;
                Console.WriteLine($"il saldo disponibile è: {Saldo}, dopo aver ritirato{tot} ");
            }
        }

        public void Versamento()
        {
            Console.WriteLine($"Quanto vorresti depositare dal tuo saldo di: {Saldo} ");
            int tot = int.Parse(Console.ReadLine());
            if(tot == 0)
            {
                Console.WriteLine("Deposita piu di 0");
            }
            else{
                Saldo = Saldo + tot;
            }
        }
    }
}
