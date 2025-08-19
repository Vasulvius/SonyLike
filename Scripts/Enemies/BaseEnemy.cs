using Godot;
using System;

public partial class BaseEnemy : Node2D, IDamageable
{
	[Export] public int _maxHealth { get; private set; } = 100;
	[Export] private Status _statusVue;
	public int _currentHealth { get; private set; }

	public override void _Ready()
	{
		_currentHealth = _maxHealth;
		_statusVue.Setup(_maxHealth, _currentHealth);
	}

	public override void _Process(double delta)
	{
	}

	public void TakeDamage(int amount)
	{
		_currentHealth -= amount;
		_statusVue.UpdateHealth(_currentHealth);
		if (_currentHealth <= 0)
		{
			Die();
		}
	}

	public void Die()
	{
		GD.Print("Enemy has died.");
	}

	public void Act()
	{
		// Wait 1 second
		
		
		// Example action: print a message
		GD.Print("Enemy is acting.");
	}
}
