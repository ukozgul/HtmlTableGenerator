using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string fileName = @"./movies.json";
        string jsonString = File.ReadAllText(fileName);
        var movie = JsonSerializer.Deserialize<List<Movies>>(jsonString);

        //Tablo başla
        string tabloBasla = "";
        //Tablo Basliklar
        string tabloBasliklar = "";
        //Tablo gövde 
        string tabloGovde = "";
        //tablo kapat
        string tabloKapat = "";

        string tablo = tabloBasla + tabloBasliklar + tabloGovde + tabloKapat;
        

    }
}