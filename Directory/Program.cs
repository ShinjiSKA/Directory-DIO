CreateDirectoryGlobe();
CreateFile();
var origin = Path.Combine(Environment.CurrentDirectory, "brazil.txt");
var destiny = Path.Combine(Environment.CurrentDirectory, "globe", "South America", "Brazil", "brazil.txt");
//MoveFile(origin, destiny);
CopyFile(origin, destiny);

static void CopyFile(string pathOrigin, string pathDestiny)
{
    if (!File.Exists(pathOrigin))
    {
        Console.WriteLine("Origin file doesn't exist");
        return;
    }
    if (File.Exists(pathDestiny))
    {
        Console.WriteLine("File already exist in the destiny folder");
        return;
    }

    File.Copy(pathOrigin, pathDestiny);
}
static void MoveFile(string pathOrigin, string pathDestiny)
{
    if (!File.Exists(pathOrigin))
    {
        Console.WriteLine("Origin file doesn't exist");
        return;
    }
    if (File.Exists(pathDestiny))
    {
        Console.WriteLine("File already exist in the destiny folder");
        return;
    }
    File.Move(pathOrigin, pathDestiny);
}
static void CreateFile()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brazil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Population: 213MM");
        sw.WriteLine("HDI: 0,901");
        sw.WriteLine("Last time updated: 04/20/2018");
    }
}

static void CreateDirectoryGlobe()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globe");
    if (!Directory.Exists(path))
    {

        var dirGlobe = Directory.CreateDirectory(path);
        var dirNorthAm = dirGlobe.CreateSubdirectory("North America");
        var dirCentralAm = dirGlobe.CreateSubdirectory("Central America");
        var dirSouthAm = dirGlobe.CreateSubdirectory("South America");

        dirNorthAm.CreateSubdirectory("USA");
        dirNorthAm.CreateSubdirectory("Mexico");
        dirNorthAm.CreateSubdirectory("Canada");

        dirCentralAm.CreateSubdirectory("Costa Rica");
        dirCentralAm.CreateSubdirectory("Panama");

        dirSouthAm.CreateSubdirectory("Brazil");
        dirSouthAm.CreateSubdirectory("Argentina");
        dirSouthAm.CreateSubdirectory("Paraguay");
    }

}