using UnityEngine;

public class PlayerActionHandler : ActionHandler
{
    public PlayerAction playerAction;

    public void SwitchAction(PlayerAction playerAction)
    {
        this.playerAction?.Exit();
        this.playerAction = playerAction;
        this.playerAction.Enter();
    }
}
