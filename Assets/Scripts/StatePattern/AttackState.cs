using UnityEngine;

public class AttackState : IEnemyState
{
    public void EnterState(EnemyController controller)
    {
        Debug.Log("Enter Attack state");
    }

    public void UpdateState(EnemyController controller)
    {
        Debug.Log("Update Attack state");
    }

    public void ExitState(EnemyController controller)
    {
        Debug.Log("Exit Attack state");
    }
}
