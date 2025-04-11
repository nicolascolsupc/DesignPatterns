using UnityEngine;

public interface IEnemyState
{
    public void EnterState(EnemyController controller);
    
    public void UpdateState(EnemyController controller);

    public void ExitState(EnemyController controller);
}
