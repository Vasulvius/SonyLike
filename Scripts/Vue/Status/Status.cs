using Godot;
using System;

public partial class Status : Control
{
    [Export] private ProgressBar _healthBar;

    public void Setup(int maxHealth, int currentHealth)
    {
        _healthBar.MaxValue = maxHealth;
        _healthBar.Value = currentHealth;
    }

    public void UpdateHealth(int currentHealth)
    {
        _healthBar.Value = currentHealth;
    }
}
