public class Cinnamon : Ingredient
{
    public override int Id { get; } = 7;
    public override string Name { get; } = "Cinnamon";
    public override string Prepare() => "Take half a teaspoon. Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
