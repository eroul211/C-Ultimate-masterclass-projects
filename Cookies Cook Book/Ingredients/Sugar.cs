public class Sugar : Ingredient
{
    public override int Id { get; } = 5;
    public override string Name { get; } = "Sugar";
    public override string Prepare() => "Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
