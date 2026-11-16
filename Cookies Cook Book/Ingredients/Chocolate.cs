public class Chocolate : Ingredient
{
    public override int Id { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string Prepare() => "Melt in a water bath. Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
