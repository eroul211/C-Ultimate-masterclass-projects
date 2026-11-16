public class Cardamom : Ingredient
{
    public override int Id { get; } = 6;
    public override string Name { get; } = "Cardamom";
    public override string Prepare() => "Take half a teaspoon. Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
