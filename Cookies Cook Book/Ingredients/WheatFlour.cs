public class WheatFlour : Ingredient
{
    public override int Id { get; } = 1;
    public override string Name { get; } = "Whear flour";
    public override string Prepare() => "Sieve. Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}
