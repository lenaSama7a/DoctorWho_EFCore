using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository
    {
        private DoctorWhoCoreDbContext _context;
        public AuthorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void CreateAuthor(string authorName)
        {
            var author = new Author { AuthorName = authorName };
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void DeleteAuthor(string authorName)
        {
            var author = _context.Authors.Where(a => a.AuthorName == authorName).FirstOrDefault();
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }

        public void UpdateAuthorName(int id, string newAuthorName)
        {
            var author = _context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();
            if (author != null)
            {
                author.AuthorName = newAuthorName;
                _context.SaveChanges();
            }
        }

        public void UpdateAuthor(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
        }
    }
}
