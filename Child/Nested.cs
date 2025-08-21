using Godot;

public partial class Nested : Node
{
    public override void _Ready()
    {
        GD.Print("Nested node is ready!");
    }

    public override void _Process(double delta)
    {
        GD.Print("Nested processing frame with delta: " + delta);
    }
}
