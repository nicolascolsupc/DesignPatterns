using UnityEngine;

public class MagicAttack : IAttack
{
    private string _name;
    private int _power;

    public MagicAttack(string name, int power)
    {
        _name = name;
        _power = power;
    }
    
    public void Attack()
    {
        Debug.Log($"Magic attack: {_name}, power: {_power}");
    }
}
