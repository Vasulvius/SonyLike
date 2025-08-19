using Godot;
using System;

public partial class BaseCharacter : Node2D, IDamageable
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
		if (Input.IsActionJustPressed("debug"))
		{
			TakeDamage(10);
		}
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
		CombatSceneManager.Instance.RemoveCombatant(this);
		QueueFree();
	}
}
