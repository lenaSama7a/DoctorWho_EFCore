using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository
    {
        private DoctorWhoCoreDbContext _context;
        public CompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void CreateCompanion(string companionName, string whoPlayed)
        {
            var companion = new Companion { CompanionName = companionName, WhoPlayed = whoPlayed };
            _context.Companions.Add(companion);
            _context.SaveChanges();
        }

        public void DeleteCompanion(string companionName)
        {
            var companion = _context.Companions.Where(x => x.CompanionName == companionName).FirstOrDefault();
            if (companion != null)
            {
                _context.Companions.Remove(companion);
                _context.SaveChanges();
            }
        }

        public void UpdateCompanion(Companion companion)
        {
            _context.Companions.Update(companion);
            _context.SaveChanges();
        }

        public Companion? GetCompanionById(int companionID)
        {
            var companion = _context.Companions.Find(companionID);
            if (companion != null)
            {
                return companion;
            }
            throw new NullReferenceException("There's no companion with this ID");
        }
    }
}
