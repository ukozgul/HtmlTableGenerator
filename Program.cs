using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string fileName = @"./movies.json";
        string jsonString = File.ReadAllText(fileName);
        var movie = JsonSerializer.Deserialize<List<Movies>>(jsonString);

        //Tablo başla
        string tabloBasla = "<table>";
        //Tablo Basliklar
        string tabloBasliklar = "<th> <tr> <td>id</td> <td>title</td> <td>rating</td> <td>genre</td> <td>duration</td> </tr> </th>";
        //Tablo gövde 
        string tabloGovde = "";
        tabloGovde += "<tbody>";
        foreach (var item in movie)
        {
            tabloGovde += "<tr>" +
            $"<td>{item.id}</td>" +
            $"<td>{item.title}</td>"+
            $"<td>{item.raiting}</ td >" +
            $"< td >{item.genre}</ td >" +
            $"< td > {item.duration} </ td >" +
        "</ tr >";
        }
        tabloGovde += "</tbody>";

        //tablo kapat
        string tabloKapat = "</table>";


        string tablo = tabloBasla + tabloBasliklar + tabloGovde + tabloKapat;
        File.WriteAllText("output.html", tablo);

    }
}