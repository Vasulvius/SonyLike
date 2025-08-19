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
        _ring.Visible = true;
    }

    private void OnMouseExited()
    {
        _ring.Visible = false;
    }

    private void OnInputEvent(Node viewport, InputEvent @event, int shapeIdx)
    {
        if (@event is InputEventMouseButton mouseButtonEvent)
        {
            if (mouseButtonEvent.IsPressed())
            {
                _panel.Visible = true;
                GetParent<Selector>().SetSelectedTarget();
            }
        }
    }

    private void HideSelectionArea()
    {
        _ring.Visible = false;
        _panel.Visible = false;
    }
}
