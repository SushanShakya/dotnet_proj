namespace program;

public class SqlServerDbService : IDbService
{

    HeroDbContext Context;

    public SqlServerDbService(HeroDbContext context)
    {
        Context = context;
    }

    public void Delete(string name)
    {
        var hero = Context.Heros!.FirstOrDefault(p => p.Name == name);
        if (hero != null)
        {
            Context.Heros!.Remove(hero);
            Context.SaveChanges();
            Console.WriteLine($"Hero {name} Removed from Db.");
        }

    }


    public void Insert(string name, int powerLvl)
    {
        var hero = new Hero() { Name = name, PowerLvl = powerLvl };
        Context.Heros!.Add(hero);
        Context.SaveChanges();
        Console.WriteLine($"New Hero {name} Added to Db.");
    }

    public void Read()
    {
        var heros = Context.Heros!.ToList();

        foreach (var p in heros)
        {
            Console.WriteLine(p);
        }
    }

    public void Update(string name, int powerLvl)
    {
        var hero = Context.Heros!.FirstOrDefault(p => p.Name == name);
        if (hero != null)
        {
            hero.PowerLvl = powerLvl;
            Context.SaveChanges();
            Console.WriteLine($"Hero {name} updated successfully.");
        }
    }

}