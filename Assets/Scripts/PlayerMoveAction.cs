using UnityEngine;

public class PlayerMoveAction : PlayerAction
{
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
        PlayerActionHandler.Animator.SetFloat("X", moveDirection.x);
        PlayerActionHandler.Animator.SetFloat("Y", moveDirection.y);
    }

    public override void Exit()
    {

    }

    public PlayerMoveAction(PlayerActionHandler playerActionHandler)
    {
        PlayerActionHandler = playerActionHandler;
    }
}
