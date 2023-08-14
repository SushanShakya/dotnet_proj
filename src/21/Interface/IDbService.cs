namespace program;

public interface IDbService
{
    public void Insert(string name, int powerLvl);
    public void Read();
    public void Update(string name, int powerLvl);
    public void Delete(string name);
}