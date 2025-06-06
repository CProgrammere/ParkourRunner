using UnityEngine;

public class PlayerActionHandler : ActionHandler
{
    [field: SerializeField] public PlayerControls PlayerControls { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }

    public PlayerAction playerAction;

    private void Awake()
    {
        PlayerControls = new PlayerControls();
        PlayerControls.Player.Enable();
    }

    private void OnEnalbe()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();
    }

    private void Start()
    {
        SwitchAction(new PlayerMoveAction(this));
    }

    private void Update()
    {
        playerAction?.Tick(Time.deltaTime);
    }


public void SwitchAction(PlayerAction playerAction)
    {
        this.playerAction?.Exit();
        this.playerAction = playerAction;
        this.playerAction.Enter();
    }
}
