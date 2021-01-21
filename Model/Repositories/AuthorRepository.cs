using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Model.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        List<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author
                {
                    Id = 1, fullName="Eslam Hussien"
                },
                new Author
                {
                    Id = 2, fullName="Ahmed"
                },
                new Author
                {
                    Id = 3, fullName="Amr Ali"
                }
            };
        }
        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            Author author = Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
            return authors.SingleOrDefault(b => b.Id == id);
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            Author author = Find(id);
            author.fullName = newAuthor.fullName;
        }
    }
}
