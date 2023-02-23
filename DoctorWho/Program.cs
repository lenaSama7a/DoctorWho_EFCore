using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
public class Program
{
    private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();

    public static void CallFnCompanions(int Id)
    {
        var companions = _context.Companions.Select(c => _context.fnCompanions(Id)).FirstOrDefault();
        Console.WriteLine(companions);
    }
    public static void CallFnEnemies(int Id)
    {
        var enemies = _context.Companions.Select(c => _context.fnEnemies(Id)).FirstOrDefault();
        Console.WriteLine(enemies);
    }

    public static void PrintViewEpisodes()
    {
        var episodes = _context.ViewEpisodes.ToList();

        foreach (var episode in episodes)
        {
            Console.WriteLine(episode.AuthorName);
            Console.WriteLine(episode.DoctorName);
            Console.WriteLine(episode.Companions);
            Console.WriteLine(episode.Enemies);
            Console.WriteLine();
        }
    }
    //Author:
    public static void CreateAuthor(string authorName)
    {
            var author = new Author { AuthorName = authorName };
            _context.Authors.Add(author);
            _context.SaveChanges();
    }

    public static void DeleteAuthor(string authorName)
    {
            var author = _context.Authors.Where(a => a.AuthorName == authorName).FirstOrDefault();
            if (author != null)
            {
                _context.Authors.Remove(author);
                 _context.SaveChanges();
            }
    }

    public static void UpdateAuthorName(int id, string newAuthorName)
    {
        var author = _context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();
        if (author != null)
        {
            author.AuthorName = newAuthorName;
            _context.SaveChanges();
        }
    }
    //Which update should I choose? 
    public static void UpdateAuthor(Author author)
    {
        _context.Authors.Update(author);
        _context.SaveChanges();
    }

    //Companion:
    public static void CreateCompanion(string companionName, string whoPlayed)
    {
        var companion = new Companion { CompanionName = companionName, WhoPlayed = whoPlayed};
        _context.Companions.Add(companion);
        _context.SaveChanges();
    }

    public static void DeleteCompanion(string companionName)
    {
        var companion = _context.Companions.Where(x => x.CompanionName == companionName).FirstOrDefault();
        if (companion != null)
        {
            _context.Companions.Remove(companion);
            _context.SaveChanges();
        }
    }

    public static void UpdateCompanion(Companion companion)
    {
        _context.Companions.Update(companion);
        _context.SaveChanges();
    }

    //Doctor:
    public static void CreateDoctor(int doctorNumber, string doctornName)
    {
        var doctor = new Doctor { DoctorNumber = doctorNumber, DoctorName = doctornName };
        _context.Doctors.Add(doctor);
        _context.SaveChanges();
    }

    public static void DeleteDoctor(string doctorName)
    {
        var doctor = _context.Doctors.Where(x => x.DoctorName == doctorName).FirstOrDefault();
        if (doctor != null)
        {
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }
    }

    public static void UpdateDoctor(Doctor doctor)
    {
        _context.Doctors.Update(doctor);
        _context.SaveChanges();
    }

    //Enemy:
    public static void CreateEnemy( string enemyName, string description)
    {
        var enemy = new Enemy { EnemyName = enemyName , Description = description };
        _context.Enemies.Add(enemy);
        _context.SaveChanges();
    }

    public static void DeleteEnemy(string enemyName)
    {
        var enemy = _context.Enemies.Where(x => x.EnemyName == enemyName).FirstOrDefault();
        if (enemy != null)
        {
            _context.Enemies.Remove(enemy);
            _context.SaveChanges();
        }
    }

    public static void UpdateEnemy(Enemy enemy)
    {
        _context.Enemies.Update(enemy);
        _context.SaveChanges();
    }

    //Episode:
    public static void CreateEpisode(int seriesNumber, int episodeNumber, string episodeType, string title, DateTime episodeDate, int authorID, int doctorID)
    {
        var episode = new Episode { SeriesNumber = seriesNumber, EpisodeNumber = episodeNumber,
            EpisodeType = episodeType, Title = title,
            EpisodeDate = episodeDate, AuthorId = authorID, DoctorId = doctorID };
        _context.Episodes.Add(episode);
        _context.SaveChanges();
    }

    public static void DeleteEpisode(int episodeID)
    {
        var episode = _context.Episodes.Where(x => x.EpisodeId == episodeID).FirstOrDefault();
        if (episode != null)
        {
            _context.Episodes.Remove(episode);
            _context.SaveChanges();
        }
    }

    public static void UpdateEpisode(Episode episode)
    {
        _context.Episodes.Update(episode);
        _context.SaveChanges();
    }

    public static void AddEnemyToEpisode(int episodeID, int enemyID)
    {
        var episode =  _context.Episodes.Find(episodeID);
        var enemy = _context.Enemies.Find(enemyID);
        if(episode != null && enemy != null)
        {
            var episodeEnemy = new EpisodeEnemy { EpisodeId = episodeID, EnemyId = enemyID };
            _context.EpisodeEnemies.Add(episodeEnemy);
            _context.SaveChanges();
        }
    }

    public static void AddCompanionToEpisode(int episodeID, int companionID)
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

    public static List<Doctor> GetAllDoctors()
    {
        var allDoctors = _context.Doctors.ToList();
        return allDoctors;
    }

    public static Enemy? GetEnemyById(int enemyID)
    {
        var enemy = _context.Enemies.Find(enemyID);
        if (enemy != null)
        {
            return enemy;
        }
        throw new NullReferenceException("There's no enemy with this ID");
    }

    public static Companion? GetCompanionById(int companionID)
    {
        var companion = _context.Companions.Find(companionID);
        if (companion != null)
        {
            return companion;
        }
        throw new NullReferenceException("There's no companion with this ID");
    }

    public static void Main(String[] args)
    {
        //CallFnCompanions(2); //Willa Cather,Joan Didion
        //CallFnEnemies(2); //Kingsley Amis,Iceberg Slim,Maria Orczy
        //PrintViewEpisodes();

        //CreateAuthor("Leena Abu Samaha");
        //DeleteAuthor("Leena Abu Samaha");
        //UpdateAuthor(new Author { AuthorName = "Lena" });
        //UpdateAuthorName(5, "Franz");

        //CreateEpisode(4, 9, "classic", "Title2", new DateTime(2023, 1, 29), 2, 3);
    }
}
