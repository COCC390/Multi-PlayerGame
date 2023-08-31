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

    #region State implement
    public void OnStateEnter()
    {
        _playerAnimController.AnimationPlay(PlayerAnim.Walk.ToString());
    }

    public void OnStateExit()
    {
    }

    public void OnStateUpdate()
    {
       
        _playerVFXController.PlayVFX(VFXName.Walk);
        _playerTransform.position += _playerController.GetMoveDir * _playerController.GetWalkSpeed * Time.deltaTime;
    }
    #endregion

    #region State function
    private void DoWalk()
    {

    }

    private void LookAtWalkDirection()
    {

    }

    #endregion
}
