using Godot;
using System;

public partial class Ring : Sprite2D
{
    public void ToggleVisibility()
    {
        Visible = !Visible;
    }
}
