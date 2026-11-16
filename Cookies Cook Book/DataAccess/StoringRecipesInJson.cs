using System.Text.Json;

public class StoringRecipesInJson : IStringsTextualRepository
{
    public void AppendAllTextFile(string filePath, List<string> id)
    {
        var updatedIds = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(filePath));

        if(id.Count() != 0)
        {
            string json = JsonSerializer.Serialize(JsonFile(id, updatedIds));
            File.WriteAllText(filePath, json);
        }
    }

    public List<List<string>> ReadFromTextFile(string filePath)
    {
       string[]? fileContents = JsonSerializer.Deserialize<string[]>(File.ReadAllText(filePath));

       List<List<string>> recipelist = new();

        foreach (string line in fileContents)
        {
            List<string> ingredients = line.Split(",").ToList();

            recipelist.Add(ingredients);
        }

        return recipelist;
    }

    public void WriteAllTextFile(string filePath, List<string> id)
    {
        if(id.Count() != 0)
        {
            string json = JsonSerializer.Serialize(JsonFile(id));
            File.WriteAllText(filePath, json);
        }
    }
    public List<string> JsonFile(List<string>id, List<string> updatedList = null)
    {
        List<string> idList = updatedList ?? new List<string>();

        string file = string.Join(",", id);
        idList.Add(file);
        return idList;
    }
}
