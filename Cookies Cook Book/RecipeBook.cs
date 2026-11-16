using System.Runtime.CompilerServices;

public class RecipeBook
{
    private List<Ingredient> _ingredientsList = new List<Ingredient>()
    { new WheatFlour(), new CoconutFlour(), new Butter(), new Chocolate(), new Sugar(), new Cardamom(), new Cinnamon(), new CocoaPowder()};

    public List<Ingredient> CreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");
        foreach(var ingredient in _ingredientsList)
        {
            Console.WriteLine($"{ingredient.Id}. {ingredient.Name}");
        }

        int count = 0;
        List<Ingredient> newRecipe = new List<Ingredient>();
        do
        {
            Console.WriteLine("Add an ingredient by it's Id or type anything else if finished");
            string input = Console.ReadLine()!;
            if (int.TryParse(input, out int number))
            {
                count++;
                foreach(Ingredient ingredient in _ingredientsList)
                {
                    if (number == ingredient.Id)
                         newRecipe.Add(ingredient);
                }
            }
            else
                break;

        } while (count != 4);
        PrintingIngredients(newRecipe);
        return newRecipe;
    }
    private void PrintingIngredients(List<Ingredient> ingredients)
    {
        Console.WriteLine("Recipe added:");
        foreach(var ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
    }
    public void PrintRecipes(List<Ingredient> recipe)
    {
        foreach (Ingredient ingredient in recipe)
        {
            Console.WriteLine(ingredient);
        }
        Console.WriteLine();
    }
    public void AddRecipes(List<List<string>> idString)
    {
       List<Ingredient> recipe = new List<Ingredient>();
        int count = 1;
        Console.WriteLine("Existing recipes are:\n");
        
        foreach (List<string> line in idString)
        {
            Console.WriteLine($"***** {count} *****");
            foreach (string id in line)
            {
                Ingredient ingredient = id switch
                {
                    "1" => new WheatFlour(),
                    "2" => new CoconutFlour(),
                    "3" => new Butter(),
                    "4" => new Chocolate(),
                    "5" => new Sugar(),
                    "6" => new Cardamom(),
                    "7" => new Cinnamon(),
                    "8" => new CocoaPowder(),
                    _ => throw new ArgumentException($"Unknown ingredient ID: {id}")
                };
                if(ingredient != null)
                    recipe.Add(ingredient);
            }
            PrintRecipes(recipe);
            count++;
            recipe = new List<Ingredient>(); 
        }
    }

}