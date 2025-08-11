using Godot;
using System;

public partial class SelectionArea : Area2D
{
    [Export] private Sprite2D _ring;
    [Export] private Panel _panel;
    public override void _Ready()
    {
        _ring.Visible = false;
        _panel.Visible = false;
    }
    private void OnMouseEntered()
    {
        ToggleRingVisibility();
    }

    private void OnMouseExited()
    {
        ToggleRingVisibility();
    }

    private void OnInputEvent(Node viewport, InputEvent @event, int shapeIdx)
    {
        if (@event is InputEventMouseButton mouseButtonEvent)
        {
            if (mouseButtonEvent.IsPressed())
            {
                TogglePanelVisibility();
            }
        }
    }

    private void ToggleRingVisibility()
    {
        _ring.Visible = !_ring.Visible;
    }

    private void TogglePanelVisibility()
    {
        _panel.Visible = !_panel.Visible;
    }
}
