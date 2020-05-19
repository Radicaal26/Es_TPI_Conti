using System;

namespace Mandrelli_Magnani_Nadifi_4J_ContoCorrente
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*
            // Creazione del primo intestatario e del suo relativo conto corrente (tradizionale)
            Intestatario A = new Intestatario("Mario", "Rossi", new DateTime(1990 , 06 , 19), "weudu8763", "via Roma", "3874636784");
            ContoCorrente AC = new ContoCorrente("IT00000001", 5000);
            // Aggiungiamo il conto alla lista di conti
            DB.AddConto(AC);
            // Stampa info intestatario e del relativo conto 
            Console.WriteLine("Intestatario: " + A.getNome() + " " + A.getCognome() + "\nData di nascita: " + A.getDataNascita() + "\nAbita in via: " + A.getIndirizzo() + "\nNumero di telefono: " + A.getTelefono());
            Console.WriteLine("Stampa del saldo di " + A.getNome() + " " + A.getCognome() + ": " + AC.getSaldo());
            // Vengono effettuati un versamento e un prelievo con la relativa stampa aggiornata
            AC.AddMovimenti(new Versamento(100, new DateTime(2020, 03, 19), AC, null));
            AC.AddMovimenti(new Prelievo(300, new DateTime(2020, 04, 10), AC, null));
            Console.WriteLine("MOVIMENTI:");
            foreach (Movimento movimento in AC.getMovimenti())
            {               
                movimento.Sommare();
                Console.Write(movimento.getImporto() + " euro" + " fatto nel: " + movimento.getDataOra() + " - saldo attuale: " + AC.getSaldo() + "\n");
            }
            Console.WriteLine("__________________________________________________________________________________________________\n");


            // Creazione del secondo intestatario
            Intestatario B = new Intestatario("Luigi", "Verdi", new DateTime(1990, 04, 26), "asdaf5678", "via Roma", "3981848734");
            // Creazione del suo conto corrente (tradizionale)
            ContoCorrente BC = new ContoCorrente("IT00000002", 2500);
            // Aggiunta del conto corrente alla lista di conti
            DB.AddConto(BC);
            // Stampa delle info del proprietario e del relativo conto
            Console.WriteLine("Intestatario: " + B.getNome() + " " + B.getCognome() + "\nData di nascita: " + B.getDataNascita() + "\nAbita in via: " + B.getIndirizzo() + "\nNumero di telefono: " + B.getTelefono());
            Console.WriteLine("Stampa del saldo di " + B.getNome() + " " + B.getCognome() + ": " + BC.getSaldo());
            // Vengono effettutati dei movimenti di prova come il versamento, il prelievo e il bonifico
            BC.AddMovimenti(new Versamento(300, new DateTime(2020, 05, 30), BC, null));
            BC.AddMovimenti(new Prelievo(100, new DateTime(2020, 07, 21), BC, null));
            BC.AddMovimenti(new Bonifico(AC, 50, -200, new DateTime(2020, 06, 06), BC, null));
            // Stampa dei movimenti effettuati
            Console.WriteLine("MOVIMENTI:");
            foreach (Movimento movimento in BC.getMovimenti())
            {
                movimento.Sommare();               
                Console.Write(movimento.getImporto() + " euro " + "fatto nel: " + movimento.getDataOra() + " - saldo attuale: " + BC.getSaldo() + "\n");
            }
            Console.WriteLine("__________________________________________________________________________________________________\n");

            //Creazione di un nuovo intestatario online e del suo relativo conto online, aggiungendolo alla lista dei conti
            Intestatario C = new Intestatario("Antonio", "Peroni", new DateTime(1968, 09, 09), "udhwoiud83", "via Lazio", "38648374683");
            ContoOnline CC = new ContoOnline("Anto384", "vero4666", "IT00000003", 10000);
            DB.AddConto(CC);
            Console.WriteLine("Intestatario: " + C.getNome() + " " + C.getCognome() + "\nData di nascita: " + C.getDataNascita() + "\nAbita in via: " + C.getIndirizzo() + "\nNumero di telefono: " + C.getTelefono());
            Console.WriteLine("Stampa del saldo di " + C.getNome() + " " + C.getCognome() + ": " + CC.getSaldo());
            //Vengono effettuati dei movimenti, aggiunti poi alla lista dei movimenti
            CC.AddMovimenti(new Versamento(1000, new DateTime(2020, 01, 07), null, CC));
            CC.AddMovimenti(new Prelievo(600, new DateTime(2020, 09, 25), null, CC));
            // Stampa dei movimenti effettuati
            Console.WriteLine("MOVIMENTI:");
            foreach (Movimento movimento in CC.getMovimenti())
            {              
                movimento.SommareOnline();
                Console.Write(movimento.getImporto() + " euro " + "fatto nel: " + movimento.getDataOra() + " - saldo: " + CC.getSaldo() + "\n");
            }
            Console.WriteLine("__________________________________________________________________________________________________\n");*/
            
            bool chiudi = false;
            string nomeBanca;
            string via;
            double saldo;
            string iban;
            string nome;
            string cognome;
            DateTime dataNascita;
            string cv;
            string abitazione;
            string numeroTelefono;
            string username;
            string password;
            double importo;
            DateTime dataMovimento;
            int maxMovimenti;
            int nMovimenti;
            string ibanPrelievo;
            string ibanVersamento;
            bool controllo = false;
            Console.WriteLine("Nome della banca:");
            nomeBanca = Console.ReadLine();
            Console.WriteLine("Via dove è ubicata la banca:");
            via = Console.ReadLine();
            Banca DB = new Banca(nomeBanca, via);

            do
            {
                Console.Clear();
                Console.WriteLine("Seleziona un opzione:");
                Console.WriteLine("1) Chiudi il programma");
                Console.WriteLine("2) Crea un conto corrente");
                Console.WriteLine("3) Aggiungi un intestario");
                Console.WriteLine("4) Stampa dati dell'intestatrio e del suo saldo");
                Console.WriteLine("5) Crea un conto corrente online");
                Console.WriteLine("6) Bonifico");
                Console.WriteLine("7) Prelievo");
                Console.WriteLine("8) Versamento");
                Console.Write("\r\nSeleziona un opzione: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Arresto del programma.");
                        chiudi = true;
                        break;
                    case "2":                        
                        Console.WriteLine("Inserisci il saldo all'interno del conto:");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inseriscil'iban del conto:");
                        iban = Console.ReadLine();
                        DB.AddConto(new ContoCorrente(iban, saldo));
                        break;
                    case "3":
                        Console.WriteLine("Inserisci il nome del proprietario:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome:");
                        cognome = Console.ReadLine();
                        Console.WriteLine("Inserisci la via dell'abitazione:");
                        abitazione = Console.ReadLine();
                        Console.WriteLine("Inserisci il codice fiscale:");
                        cv = Console.ReadLine();
                        Console.WriteLine("Inserisci la data di nascita:");
                        dataNascita = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Inserisci il numero di telefono:");
                        numeroTelefono = Console.ReadLine();
                        DB.AddIntestatario(new Intestatario(nome, cognome, dataNascita, cv, abitazione, numeroTelefono));
                        break;
                    case "4":
                        controllo = false;
                        Console.Write("Iban del conto in cui vuole prelevare: ");
                        iban = Console.ReadLine();
                        foreach (ContoCorrente conto in DB.getConti())
                        {
                            if (iban == conto.getIban())
                            {
                                Console.WriteLine("Intestatario: " + conto.getNomeintestatario() + " " + conto.getCognomeIntestataro() + "\nData di nascita: " + conto.getDataNascitaIntesatario() + "\nAbita in via: " + conto.getAbitazioneIntestatario() + "\nNumero di telefono: " + conto.getTelefonoIntestatario());
                                Console.WriteLine("Stampa del saldo di " + conto.getNomeintestatario() + " " + conto.getCognomeIntestataro() + ": " + conto.getSaldo());
                                controllo = true;
                            }
                        }
                        if (controllo == false)
                        {
                            Console.WriteLine("Non è stato trovato un conto con questo iban.");
                        }
                        break;
                    case "5":
                        Console.Write("Username:");
                        username = Console.ReadLine();
                        Console.Write("Password:");
                        password = Console.ReadLine();
                        Console.Write("Iban del conto:");
                        iban = Console.ReadLine();
                        Console.Write("Saldo del conto:");
                        saldo = Convert.ToDouble(Console.ReadLine());
                        DB.AddConto(new ContoOnline(username, password, iban, saldo));
                        break;
                    case "6":
                        importo = 0;
                        Console.Write("Iban del conto in cui vuole prelevare: ");
                        ibanPrelievo = Console.ReadLine();
                        Console.Write("Iban del conto in cui vuole versare: ");
                        ibanVersamento = Console.ReadLine();
                        Console.Write("Quanto vuole versare/prelevare?: ");
                        importo = Convert.ToDouble(Console.ReadLine());
                        dataMovimento = DateTime.Today;
                        int commissione = 50;
                        controllo = false;
                        ContoCorrente posto = null;
                        Bonifico b = new Bonifico(null, commissione, importo, dataMovimento, null, null);
                        foreach (ContoCorrente conto in DB.getConti())
                        {
                            if (ibanVersamento == conto.getIban())
                            {
                                posto = conto;
                            }
                        }

                        if (posto != null)
                        {
                            foreach (ContoCorrente conto in DB.getConti())
                            {
                                if (ibanPrelievo == conto.getIban())
                                {
                                    conto.AddMovimenti(b);
                                    b.EseguiBonifico(posto, conto);
                                    controllo = true;
                                }
                            }
                            Console.Write("Bonifico effettuato con successo.");
                        }

                        if (controllo == false)
                        {
                            Console.WriteLine("Non è stato trovato uno dei 2 conti con questi iban..");
                        }
                        break;
                    case "7":
                        Console.Write("Iban del conto in cui vuole prelevare: ");
                        iban = Console.ReadLine();
                        Console.Write("Importo da prelevare: ");
                        importo = Convert.ToDouble(Console.ReadLine());
                        dataMovimento = DateTime.Today;
                        controllo = false;
                        foreach (ContoCorrente conto in DB.getConti())
                        {
                            if (iban == conto.getIban())
                            {
                                maxMovimenti = conto.getMaxMovimenti();
                                nMovimenti = conto.getNumeroMovimenti();

                                if (nMovimenti < maxMovimenti)
                                {
                                    if (conto is ContoCorrente)
                                    {
                                        if (conto.getSaldo() >= importo)
                                        {
                                            Prelievo p = new Prelievo(importo, dataMovimento, null, null);
                                            conto.AddMovimenti(p);
                                            p.Sommare(conto);
                                            controllo = true;
                                            Console.WriteLine("Prelievo effettuato con successo");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Non puo prelevare di piu del saldo nel conto = " + conto.getSaldo());
                                            controllo = true;
                                        }
                                    }
                                    else
                                    {
                                        if (conto.getSaldo() >= importo)
                                        {
                                            if (importo <= 1000)
                                            {
                                                Prelievo p = new Prelievo(importo, dataMovimento, null, null);
                                                conto.AddMovimenti(p);
                                                p.Sommare(conto);
                                                controllo = true;
                                                Console.WriteLine("Prelievo effettuato con successo.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Importo massimo per ogni prelievo : 1000 euro");
                                                controllo = true;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Non puo prelevare di piu del saldo nel conto = " + conto.getSaldo());
                                            controllo = true;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Superato il limite dei movimenti = " + conto.getMaxMovimenti());
                                    controllo = true;
                                }
                            }
                        }
                        if (controllo == false)
                        {
                            Console.WriteLine("Non è stato trovato un conto con questo iban.");
                        }
                        break;
                    case "8":
                        Console.Write("Iban del conto in cui vuole versare: ");
                        iban = Console.ReadLine();
                        Console.Write("Importo da versare: ");
                        importo = Convert.ToDouble(Console.ReadLine());
                        dataMovimento = DateTime.Today;
                        controllo = false;
                        foreach (ContoCorrente conto in DB.getConti())
                        {
                            if (iban == conto.getIban())
                            {
                                maxMovimenti = conto.getMaxMovimenti();
                                nMovimenti = conto.getNumeroMovimenti();
                                if (nMovimenti < maxMovimenti)
                                {
                                    if (importo <= 1000)
                                    {
                                        Versamento v = new Versamento(importo, dataMovimento, null, null);
                                        conto.AddMovimenti(v);
                                        v.Sommare(conto);
                                        controllo = true;
                                        Console.WriteLine("Versamento effettuato con successo.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Importo massimo per ogni versamento : 1000 euro");
                                        controllo = true;
                                    }
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Superato il limite dei movimenti = " + conto.getMaxMovimenti());
                                    controllo = true;
                                }
                            }
                        }
                        if (controllo == false)
                        {
                            Console.WriteLine("Non è stato trovato un conto con questo iban.");
                        }
                        break;

                    default:
                        Console.WriteLine("Hai inserito un opzione non presente.");
                        break;
                }
            } while (chiudi == false) ;
        } 
    }
}
