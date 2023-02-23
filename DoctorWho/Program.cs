using DoctorWho.Db;
using DoctorWho.Db.Repositories;
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
    
    public static void Main(String[] args)
    {
        //CallFnCompanions(2); //Willa Cather,Joan Didion
        //CallFnEnemies(2); //Kingsley Amis,Iceberg Slim,Maria Orczy
        //PrintViewEpisodes();

        AuthorRepository authorRepository = new(_context);
        authorRepository.CreateAuthor("Leena");
        authorRepository.DeleteAuthor("Leena");
    }
}
