
using System.Collections.Specialized;

public class StoringRecipesInText : IStringsTextualRepository
{
    public List<List<string>> ReadFromTextFile(string filePath)
    {
        string[] fileContents = File.ReadAllLines(filePath);

        List<List<string>> recipelist = new();


        foreach(string line in fileContents)
        {
            List<string> ingredients = line.Split(",").ToList();

            recipelist.Add(ingredients);
        }

        return recipelist;
    }

    public void WriteAllTextFile(string filePath, List<string> id)
    {
        if(id.Count() != 0)
            File.WriteAllText(filePath, string.Join(",", id) + Environment.NewLine);
    }
    public void AppendAllTextFile(string filePath, List<string> id)
    {
        if(id.Count() != 0)
            File.AppendAllText(filePath, string.Join(",", id) + Environment.NewLine);
    }

}
