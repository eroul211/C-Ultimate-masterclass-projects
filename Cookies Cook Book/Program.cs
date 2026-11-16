
using System.Collections;

const string fileName = "recipes";
const FileFormat format = FileFormat.Json;

var recipe = new RecipeBook();
var storingRecipe = ChangeFormat();
string filePath = fileName + "." + format.ToString().ToLower();


if (File.Exists(filePath))
{
    recipe.AddRecipes(storingRecipe.ReadFromTextFile(filePath));
    storingRecipe.AppendAllTextFile(filePath, FileContents.CreateAndAddRecipeToFile(recipe));
}
else
{
    storingRecipe.WriteAllTextFile(filePath, FileContents.CreateAndAddRecipeToFile(recipe));
}

IStringsTextualRepository ChangeFormat() => format switch
{
    FileFormat.Txt => new StoringRecipesInText(),
    FileFormat.Json => new StoringRecipesInJson()
};
