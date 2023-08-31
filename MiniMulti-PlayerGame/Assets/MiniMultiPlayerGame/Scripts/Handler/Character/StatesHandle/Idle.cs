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

    public void OnStateEnter()
    {
        _playerVFXController.PlayVFX("idle vfx");
        _animController.AnimationPlay(PlayerAnim.Idle.ToString());
    }

    public void OnStateExit()
    {
    }

    public void OnStateUpdate()
    {
        _playerVFXController.PlayVFX("idle vfx on update");
    }

}
