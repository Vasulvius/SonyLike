using Godot;

public partial class CombatSceneManager : Node
{
    // Singleton instance
    private static CombatSceneManager _instance;

    public static CombatSceneManager Instance => _instance;

    // Combatants in the current scene
    public Godot.Collections.Array<Node> Characters = new Godot.Collections.Array<Node>();
    public Godot.Collections.Array<Node> Enemies = new Godot.Collections.Array<Node>();
    private Godot.Collections.Array<Node> _combatants = new Godot.Collections.Array<Node>();
    private int _currentCombatantIndex = 0;

    public override void _Ready()
    {
        // Singleton pattern
        if (_instance != null && _instance != this)
        {
            QueueFree();
            return;
        }

        _instance = this;

        // Initialize combatants array
        InitializeCombatants();
        HandleCurrentCombatant();
    }


    private void InitializeCombatants()
    {
        // Get all nodes in the "Character" and "Enemy" groups
        Characters = GetTree().GetNodesInGroup("Character");
        Enemies = GetTree().GetNodesInGroup("Enemy");
        _combatants = GetTree().GetNodesInGroup("Character") + GetTree().GetNodesInGroup("Enemy");

        // TODO : Sort combatants regarding there stats
    }

    private void HandleCurrentCombatant()
    {
        if (_combatants[_currentCombatantIndex] is BaseEnemy enemy)
        {
            enemy.Act();
        }
    }

    private void SelectNextCombatant()
    {
        _currentCombatantIndex = (_currentCombatantIndex + 1) % _combatants.Count;
        HandleCurrentCombatant();
    }

    public void HandleEndTurn()
    {
        SelectNextCombatant();
    }

    public void RemoveCombatant(Node combatant)
    {
        _combatants.Remove(combatant);
        Characters.Remove(combatant);
        Enemies.Remove(combatant);

        if (Enemies.Count == 0)
        {
            Win();
        }
        else if (Characters.Count == 0)
        {
            Lose();
        }
    }

    public void Win()
    {
        GD.Print("All enemies have been defeated.");
    }

    public void Lose()
    {
        GD.Print("All characters have been defeated.");
    }
}
