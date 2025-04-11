using UnityEngine;

public class FollowState : IEnemyState
{
    private float _attackDistance = 2f;
    private float _rangeFollowDistance = 15;
    
    public void EnterState(EnemyController controller)
    {
        //Set Target on navmeshAgent
        
        //Start Idle Animation
        controller.Animator.Play("Walk");
    }

    public void UpdateState(EnemyController controller)
    {
        //Set Target on navmeshAgent
        //controller.Agent.SetTarget(controller.target);

        if (Vector2.Distance(controller.transform.position, controller.target.position) < _attackDistance)
        {
            controller.SetState(new AttackState());
            return;
        }

        if (Vector2.Distance(controller.transform.position, controller.target.position) > _rangeFollowDistance)
        {
            controller.SetState(new IdleState());
        }
    }

    public void ExitState(EnemyController controller)
    {
        Debug.Log("Exit Follow state");
    }
}
