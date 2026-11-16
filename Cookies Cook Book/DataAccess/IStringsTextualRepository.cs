using System.Globalization;

public interface IStringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    List<List<string>> ReadFromTextFile(string filePath);
    void WriteAllTextFile(string filePath, List<string> id);
    void AppendAllTextFile(string filePath, List<string> id);
}
