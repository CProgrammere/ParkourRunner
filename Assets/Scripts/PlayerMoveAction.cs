using UnityEngine;
using System;

public class MoveEventArg : EventArgs
{
    public Vector2 Direction;
}

public class PlayerMoveAction : PlayerAction
{
    public static event EventHandler OnMoveAnimation;


    private Vector2 moveDirection;
    private int moveHash = Animator.StringToHash("MoveBelndTree");

    public override void Enter()
    {
        PlayerActionHandler.Animator.CrossFadeInFixedTime(moveHash, 0.1f);
    }

    public override void Tick(float deltaTime)
    {
        moveDirection = PlayerActionHandler.PlayerControls.Player.Walk.ReadValue<Vector2>();
        moveDirection.Normalize();
        Debug.Log(moveDirection);
        OnMoveAnimation?.Invoke(this, new MoveEventArg { Direction = moveDirection });
    }

    public override void Exit()
    {

    }

    public PlayerMoveAction(PlayerActionHandler playerActionHandler)
    {
        PlayerActionHandler = playerActionHandler;
    }
}
