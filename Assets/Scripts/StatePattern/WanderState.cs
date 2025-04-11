using UnityEngine;

public class WanderState : IEnemyState
{
    private float _distance;
    private int i;
    public void EnterState(EnemyController controller)
    {
        //Set Target on waypoint
        
        //Start Idle Animation
        controller.Animator.Play("Walk");
    }

    public void UpdateState(EnemyController controller)
    {
        //Set Target on navmeshAgent
        //controller.Agent.SetTarget(controller.target);
        
        //if (Vector2.Distance(controller.transform.position, controller.waypoint[i].position) < _distance)
        {
            i++;
        }

        if (controller.target != null)
        {
            controller.SetState(new FollowState());
        }
    }

    public void ExitState(EnemyController controller)
    {
        Debug.Log("Exit Follow state");
    }
}
