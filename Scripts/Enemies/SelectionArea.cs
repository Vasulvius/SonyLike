using Godot;
using System;

public partial class SelectionArea : Area2D
{
    [Export] private Ring _ring;
    [Export] private AbilitiesPanel _panel;
    public override void _Ready()
    {
        _ring.Visible = false;
        _panel.Visible = false;
    }
    private void OnMouseEntered()
    {
        _ring.ToggleVisibility();
    }

    private void OnMouseExited()
    {
        _ring.ToggleVisibility();
    }

    private void OnInputEvent(Node viewport, InputEvent @event, int shapeIdx)
    {
        if (@event is InputEventMouseButton mouseButtonEvent)
        {
            if (mouseButtonEvent.IsPressed())
            {
                _panel.ToggleVisibility();
                GetParent<Selector>().SetSelectedTarget();
            }
        }
    }
}
