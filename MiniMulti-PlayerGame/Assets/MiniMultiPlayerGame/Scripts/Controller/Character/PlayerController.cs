using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerState _playerState = new PlayerState();
    [SerializeField] private StateMachine _playerStateMachine;
    [SerializeField] private PlayerInput _playerInput;

    [SerializeField] private PlayerVFXController _playerVFXController;
    [SerializeField] private PlayerAnimationController _playerAnimController;

    //[SerializeField] private StateCreator _stateCreator;

    [SerializeField] private float _walkSpeed = 2f;
    private Vector3 _moveDir;

    public float GetWalkSpeed { get { return _walkSpeed; } }
    public Vector3 GetMoveDir { get { return _moveDir; } }

    public void GroundMovement(InputAction.CallbackContext context)
    {
        Vector2 moveDirIn2d = context.ReadValue<Vector2>();

        IState newState;

        _moveDir = new Vector3(moveDirIn2d.x, transform.position.y, moveDirIn2d.y);

        if (_playerState.walkState == null)
            _playerState.walkState = new Walk(transform, this, _playerVFXController, _playerAnimController);

        if (moveDirIn2d == Vector2.zero)
        {
            if (_playerState.idleState == null)
                _playerState.idleState = new Idle(_playerAnimController, _playerVFXController);

            newState = _playerState.idleState;
        }
        else
        {
            newState = _playerState.walkState;
        }

        _playerStateMachine.ChangeStateAction?.Invoke(newState);
    }    
}

public class PlayerState
{
    public Idle idleState;
    public Walk walkState;
}
