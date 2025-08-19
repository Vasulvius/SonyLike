using Godot;
using System;
using System.Runtime;

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
		CombatSceneManager.Instance.RemoveCombatant(this);
		QueueFree();
	}

	private Node SelectTarget()
	{
		return CombatSceneManager.Instance.Characters[0];
	}

	public void Act()
	{
		GD.Print("Enemy starts acting...");
		var timer = GetTree().CreateTimer(1.0);
		timer.Timeout += OnActComplete;
	}

	private void OnActComplete()
	{
		GD.Print("Enemy is acting.");
		IDamageable target = SelectTarget() as IDamageable;
		target.TakeDamage(20);
		CombatSceneManager.Instance.HandleEndTurn();
	}
}
