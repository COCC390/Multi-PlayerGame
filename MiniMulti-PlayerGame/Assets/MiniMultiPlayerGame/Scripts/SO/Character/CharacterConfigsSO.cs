using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConfigsSO : ScriptableObject
{
    [Header("GroundMovement")]
    public float walkSpeed = 5f;
    public float runSpeed = 10f;

    [Header("Jumping")]
    public float jumpForce = 5f;
    public float maxJumpHeight;

    [Header("CharacterStrength")]
    public float HP = 100f;
    public float MP = 100f;


}
