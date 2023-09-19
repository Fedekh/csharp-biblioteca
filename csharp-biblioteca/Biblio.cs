using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblio
    {
        private List<User> users = new List<User>();
        private List<Loan> loans = new List<Loan>();
        private List<Document> documents = new List<Document>();

        public void InserUser(User user)
        {
            if (user == null)
            {
                Console.WriteLine("Nessun utente inserito");
            }
            else
            {
                this.users.Add(user);
            }
        }
       
        public void InserDocument (Document document)
        {
            if (document == null)
            {
                Console.WriteLine("Nessun documento inserito");
            }
            else
            {
                this.documents.Add(document);
            }
        }


        //effettuare una ricerca di documenti per codice o titolo
        public List<Document> SearchDocument(string filter)
        {
            return documents.Where(d => d.Code.Contains(filter) || d.Title.Contains(filter)).ToList();
        }

        // prendere in prestito un documento
        public void TakeLoan(User user, Document document, DateTime begin, DateTime end)
        {
            if (documents.Contains(document))
            {
                Loan loan = new Loan
                {
                    User = user,
                    Document = document,
                    Begin = begin,
                    End = end
                };

                loans.Add(loan);
            }
            else
            {
                Console.WriteLine("Il documento non è disponibile in biblioteca.");
            }
        }

        // cercare prestiti per nome e cognome dell'utente
        public List<Loan> SearchLoan(string name, string lastname)
        {
            return loans.Where(p => p.User.Name == name && p.User.Lastname == lastname).ToList();
        }
    }

}
