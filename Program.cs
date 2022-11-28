using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string fileName = @"./movies.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var movie = JsonSerializer.Deserialize<List<Movies>>(jsonString,options);

      

        //Tablo başla
        string tabloBasla = "<table>";
        //Tablo Basliklar
        string tabloBasliklar = "<th> <tr>" +
        "<td>id</td>" +
        "<td>title</td>" +
        "<td>rating</td>" +
        "<td>genre</td>" +
        "<td>duration</td>" +
        "</tr> </th>";
        //Tablo gövde 
        string tabloGovde = "";
        tabloGovde += "<tbody>";
        foreach (var item in movie)
        {
            tabloGovde += "<tr>" +
            $"<td>{item.Id}</td>" +
            $"<td>{item.Title}</td>" +
            $"<td>{item.Raiting}</ td >" +
            $"< td >{item.Genre}</ td >" +
            $"< td > {item.Duration} </ td >" +
        "</ tr >";
        }
        tabloGovde += "</tbody>";

        //tablo kapat
        string tabloKapat = "</table>";


        string tablo = tabloBasla + tabloBasliklar + tabloGovde + tabloKapat;
        File.WriteAllText("output.html", tablo);

    }
}