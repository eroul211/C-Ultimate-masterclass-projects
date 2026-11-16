public static class FileContents
{
    public static List<string> CreateAndAddRecipeToFile(RecipeBook addRecipe)
    {
        List<Ingredient> createRecipe = addRecipe.CreateRecipe();


        List<string> idList = new List<string>();
        foreach (Ingredient ingredient in createRecipe)
        {
            idList.Add(ingredient.Id.ToString());
        }
        return idList;
    }
}