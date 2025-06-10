using UnityEngine;
using System;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    //[SerializeField] private Dictionary<string, Avatar>() avatars;

    private void Awake()
    {
        //PlayerAction.OnMoveAnimation +=
    }

    private void PlayerACtion_OnMoveAnimation(object sender, MoveEventArg e)
    {
        if(e.Direction.x > e.Direction.y)
        {

        }
    }
}
