using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : IState
{
    private Transform _playerTransform;

    private PlayerController _playerController;
    private VFXController _playerVFXController;
    private PlayerAnimationController _playerAnimController;

    public Walk() { }

    public Walk(Transform playerTransform, PlayerController playerController, VFXController playerVFXController, PlayerAnimationController playerAnimController)
    {
        _playerTransform = playerTransform;
        _playerController = playerController;
        _playerVFXController = playerVFXController;
        _playerAnimController = playerAnimController;
    }

    public void AddControl<T>(T control)
    {
        object convertControl = (T)(object)control;
        _playerVFXController = (PlayerVFXController)convertControl;
    }

    public void OnStateEnter()
    {
        
    }

    public void OnStateExit()
    {
    }

    public void OnStateUpdate()
    {
        _playerVFXController.PlayVFX(VFXName.Walk);
        _playerTransform.position += _playerController.GetMoveDir * _playerController.GetWalkSpeed * Time.deltaTime;
    }
}
