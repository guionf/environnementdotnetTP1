using System.Data.Entity;
using TP1.Entities;

namespace TP1.Database
{
    public class MyDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookShop> BookShops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Editor> Editors { get; set; }

        public MyDbContext()
        {
            if (this.Database.CreateIfNotExists())
            {
                // ajout de 2 auteurs
                for (int i = 0; i <= 2; i++)
                {
                    this.Authors.Add(new Entities.Author() { Firstname = "Prénom de l'auteur" + i, Lastname = "Nom de l'auteur : " + i });
                }
                this.SaveChanges();

                // ajout de 1 éditeur
                for (int i = 0; i <= 1; i++)
                {
                    this.Editors.Add(new Entities.Editor() { Name = "Editeur : " + i });
                }
                this.SaveChanges();

                // ajout de 10 livres 
                for (int i = 0; i <= 10; i++)
                {
                    this.Books.Add(new Entities.Book() { Name = "Titre du livre" + i, Nb_page = "Nombre de pages : " + i });
                }
                this.SaveChanges();

                // ajout de 2 librairies
                for (int i = 0; i <= 2; i++)
                {
                    this.BookShops.Add(new Entities.BookShop() { Name = "Nom de la librairie : " + i });
                }
                this.SaveChanges();

                // ajout de 2 clients
                for (int i = 0; i <= 2; i++)
                {
                    this.Customers.Add(new Entities.Customer() { Firstname = "Prénom du client : " + i, Lastname = "Nom du client : " + i });
                }
                this.SaveChanges();
            }
        }
    }
}
