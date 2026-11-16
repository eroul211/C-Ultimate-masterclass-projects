public class Butter : Ingredient
{
    public override int Id { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string Prepare() => "Melt on low heat. Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
