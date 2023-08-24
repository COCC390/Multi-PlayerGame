using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : IState
{
    private float _walkSpeed;
    private Vector3 _direction;
    private Transform _playerTransform;

    private PlayerVFXController _playerVFXController;
    private PlayerAnimationController _playerAnimController;

    public void AddControl<T>(T control)
    {
        //  
    }

    public void OnStateEnter()
    {
        _playerVFXController 
    }

    public void OnStateExit()
    {
        throw new System.NotImplementedException();
    }

    public void OnStateUpdate()
    {
        throw new System.NotImplementedException();
    }
}
