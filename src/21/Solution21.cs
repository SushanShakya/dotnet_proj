namespace program;

public class Solution21 : ISolution
{
    public void Execute()
    {
        using (var context = new HeroDbContext())
        {
            var service = new SqlServerDbService(context);
            var name = "Sushan";
            service.Insert(name, 100);
            service.Read();
            service.Update(name, 200);
            service.Read();
            service.Delete(name);
        }
        Utility.printStudentInfo("21");
    }
}