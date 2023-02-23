using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EpisodeEnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }
        public void AddEnemyToEpisode(int episodeID, int enemyID)
        {
            var episode = _context.Episodes.Find(episodeID);
            var enemy = _context.Enemies.Find(enemyID);
            if (episode != null && enemy != null)
            {
                var episodeEnemy = new EpisodeEnemy { EpisodeId = episodeID, EnemyId = enemyID };
                _context.EpisodeEnemies.Add(episodeEnemy);
                _context.SaveChanges();
            }
        }
    }
}
