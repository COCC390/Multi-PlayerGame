using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private StateMachine _playerStateMachine;
    [SerializeField] private PlayerInput _playerInput;

    [SerializeField] private StateCreator _stateCreator;

    [SerializeField] private float _walkSpeed = 2f;
    private Vector3 _moveDir;

    private void FixedUpdate()
    {
        transform.position += _moveDir * _walkSpeed * Time.deltaTime;
    }

    public void GroundMovement(InputAction.CallbackContext context)
    {
        Vector2 moveDirIn2d = context.ReadValue<Vector2>();
        _moveDir = new Vector3(moveDirIn2d.x, transform.position.y, moveDirIn2d.y);

        IState nextState = _stateCreator.CreateNextState();

        _playerStateMachine.ChangeStateAction(new Walk());
    }    
}
