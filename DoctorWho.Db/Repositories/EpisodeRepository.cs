using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void CreateEpisode(int seriesNumber, int episodeNumber, string episodeType, string title, DateTime episodeDate, int authorID, int doctorID)
        {
            var episode = new Episode
            {
                SeriesNumber = seriesNumber,
                EpisodeNumber = episodeNumber,
                EpisodeType = episodeType,
                Title = title,
                EpisodeDate = episodeDate,
                AuthorId = authorID,
                DoctorId = doctorID
            };
            _context.Episodes.Add(episode);
            _context.SaveChanges();
        }

        public void DeleteEpisode(int episodeID)
        {
            var episode = _context.Episodes.Where(x => x.EpisodeId == episodeID).FirstOrDefault();
            if (episode != null)
            {
                _context.Episodes.Remove(episode);
                _context.SaveChanges();
            }
        }

        public void UpdateEpisode(Episode episode)
        {
            _context.Episodes.Update(episode);
            _context.SaveChanges();
        }

    }
}
