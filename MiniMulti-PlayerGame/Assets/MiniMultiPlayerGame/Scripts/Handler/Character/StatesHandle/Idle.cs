using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniMultiPlayerGame.StateMachine;

public class Idle : IState
{
    private PlayerAnimationController _animController;
    private PlayerVFXController _playerVFXController;

    public void OnStateEnter()
    {
        
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
