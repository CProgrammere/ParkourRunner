using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public static PlayerStateMachine Instance { get; private set; }

    [field: SerializeField] public InputController InputController { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }

    public PlayerState playerState;

    private void Awake()
    {
        try
        {
            if(Instance != null)
            {
                Debug.LogError("More then one PlayerActionHandler in the scene!");
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        finally
        {

        }
    }

    private void Start()
    {
        SwitchAction(new PlayerMoveState(this));
    }

    private void Update()
    {
        playerState?.Tick(Time.deltaTime);
    }


public void SwitchAction(PlayerState playerState)
    {
        this.playerState?.Exit();
        this.playerState = playerState;
        this.playerState.Enter();
    }
}
