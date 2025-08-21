using Godot;

public partial class Secondary : Node
{
    public override void _Ready()
    {
        GD.Print("Secondary node is ready!");
    }

    public override void _Process(double delta)
    {
        GD.Print("Secondary processing frame with delta: " + delta);
    }
}
