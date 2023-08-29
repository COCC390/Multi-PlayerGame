using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniMultiPlayerGame.StateMachine;

public class Idle : IState
{
    private PlayerAnimationController _animController;
    private PlayerVFXController _playerVFXController;

    public Idle(PlayerAnimationController animController, PlayerVFXController playerVFXController)
    {
        _animController = animController;
        _playerVFXController = playerVFXController;
    }

    public void AddControl<T>(T control)
    {
        object convertControl = (T)(object) control;
        _playerVFXController = (PlayerVFXController)convertControl;
    }

    public void OnStateEnter()
    {
        _playerVFXController.PlayVFX("idle vfx");
    }

    public void OnStateExit()
    {
    }

    public void OnStateUpdate()
    {
        _playerVFXController.PlayVFX("idle vfx on update");
    }

}
