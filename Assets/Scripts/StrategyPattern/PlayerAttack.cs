using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private IAttack _currentAttack;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _currentAttack != null)
        {
            _currentAttack.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetAttack(new MagicAttack("abrakadabra", 16));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetAttack(new MeleeAttack("Juan", 16.4f));
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetAttack(new WeaponAttack("Pistol", 55));
        }
    }

    public void SetAttack(IAttack newAttack)
    {
        _currentAttack = newAttack;
    }
}
