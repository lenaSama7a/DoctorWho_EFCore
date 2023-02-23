using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        private DoctorWhoCoreDbContext _context;
        public EnemyRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void CreateEnemy(string enemyName, string description)
        {
            var enemy = new Enemy { EnemyName = enemyName, Description = description };
            _context.Enemies.Add(enemy);
            _context.SaveChanges();
        }

        public void DeleteEnemy(string enemyName)
        {
            var enemy = _context.Enemies.Where(x => x.EnemyName == enemyName).FirstOrDefault();
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
                _context.SaveChanges();
            }
        }

        public void UpdateEnemy(Enemy enemy)
        {
            _context.Enemies.Update(enemy);
            _context.SaveChanges();
        }

        public Enemy? GetEnemyById(int enemyID)
        {
            var enemy = _context.Enemies.Find(enemyID);
            if (enemy != null)
            {
                return enemy;
            }
            throw new NullReferenceException("There's no enemy with this ID");
        }
    }
}
