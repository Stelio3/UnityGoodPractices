using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

[Serializable]
public class StateMachine
{
    public IState CurrentState { get; private set; }
    //public WalkState walkState;
    //public JumpState jumpState;
    public IdleState idleState;
    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }
    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }
    public void Update()
    {
        if (CurrentState != null)
        {
            CurrentState.Update();
        }
    }
    //public StateMachine(PlayerController player)
    //{
    //    this.walkState = new WalkState(player);
    //    this.jumpState = new JumpState(player);
    //    this.idleState = new IdleState(player);
    //}
}