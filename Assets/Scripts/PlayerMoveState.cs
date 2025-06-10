using UnityEngine;
using System;

public class MoveEventArg : EventArgs
{
    public Vector2 Direction;
}

public class PlayerMoveState : PlayerState
{
    public static event EventHandler OnMoveAnimation;


    private Vector2 moveDirection;
    private int moveHash = Animator.StringToHash("MoveBelndTree");

    public override void Enter()
    {
        PlayerStateMachine.Animator.CrossFadeInFixedTime(moveHash, 0.1f);
    }

    public override void Tick(float deltaTime)
    {
        moveDirection = InputController.MoveDir;
        moveDirection.Normalize();
        Debug.Log(moveDirection);
        OnMoveAnimation?.Invoke(this, new MoveEventArg { Direction = moveDirection });
    }

    public override void Exit()
    {

    }

    public PlayerMoveState(PlayerStateMachine playerStateMachine)
    {
        PlayerStateMachine = playerStateMachine;
    }
}
