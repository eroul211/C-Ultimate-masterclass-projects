public class CocoaPowder : Ingredient
{
    public override int Id { get; } = 8;
    public override string Name { get; } = "Cocoa powder";
    public override string Prepare() => "Add to other ingredients.";
    public override string ToString() => Name + ". " + Prepare();
}