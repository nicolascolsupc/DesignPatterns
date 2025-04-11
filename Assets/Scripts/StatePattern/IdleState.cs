using UnityEngine;

public class IdleState : IEnemyState
{
    private float _elapsedTime;
    private float _timeOnIdle = 5;
    public void EnterState(EnemyController controller)
    {
        //Stop Movement with rigidbody
        controller.Rigidbody.linearVelocity = Vector2.zero;
        
        //Start Idle Animation
        controller.Animator.Play("Idle");

        _elapsedTime = 0;
    }

    public void UpdateState(EnemyController controller)
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _timeOnIdle)
        {
            controller.SetState(new WanderState());
        }
    }

    public void ExitState(EnemyController controller)
    {
        Debug.Log("Exit Idle State");
    }
}
