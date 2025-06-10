using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections.Generic;
using System.Collections;

public class InputController : MonoBehaviour, PlayerControls.IPlayerActions
{
    public static event Action OnAnyJump;
    public static Vector2 MoveDir;
}
