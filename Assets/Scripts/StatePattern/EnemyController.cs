using System;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private IEnemyState _currentState;
    
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    public Transform target;
    
    public Rigidbody2D Rigidbody => _rigidbody2D;
    public Animator Animator => _animator;

    private void Start()
    {
        SetState(new IdleState());
    }

    private void Update()
    {
        _currentState?.UpdateState(this);
    }


    public void SetState(IEnemyState state)
    {
        if (state == null) return;

        _currentState?.ExitState(this);

        _currentState = state;
        
        _currentState.EnterState(this);
    }
}
