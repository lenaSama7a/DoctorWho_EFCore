using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeCompanionRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void AddCompanionToEpisode(int episodeID, int companionID)
        {
            var episode = _context.Episodes.Find(episodeID);
            var companion = _context.Companions.Find(companionID);
            if (episode != null && companion != null)
            {
                var episodeCompanion = new EpisodeCompanion { EpisodeId = episodeID, CompanionId = companionID };
                _context.EpisodeCompanions.Add(episodeCompanion);
                _context.SaveChanges();
            }
        }
    }
}
