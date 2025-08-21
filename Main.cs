using Godot;

public partial class Main : Node
{

    public override void _Ready()
    {
        GD.Print("Main node is ready!");
    }

    public override void _Process(double delta)
    {
        GD.Print("Processing frame with delta: " + delta);
    }
}
