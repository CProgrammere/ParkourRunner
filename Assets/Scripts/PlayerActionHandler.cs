using UnityEngine;

public class PlayerActionHandler : ActionHandler
{
    [field: SerializeField] public PlayerControls PlayerControls { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }

    public PlayerAction playerAction;

    private void Awake()
    {
        SwitchAction(new PlayerMoveAction(this));
        PlayerControls = new PlayerControls();
    }

    private void OnEnalbe()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();
    }

    public void SwitchAction(PlayerAction playerAction)
    {
        this.playerAction?.Exit();
        this.playerAction = playerAction;
        this.playerAction.Enter();
    }
}
