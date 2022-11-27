using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string fileName = @"./movies.json";
        string jsonString = File.ReadAllText(fileName);

     
    }
}
