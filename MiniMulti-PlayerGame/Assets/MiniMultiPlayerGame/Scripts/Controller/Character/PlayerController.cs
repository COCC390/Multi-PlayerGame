using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput _playerInput;

    [SerializeField] private NewStateFactory _stateFactory;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnGroundMove(InputValue inputValue) 
    {
        Debug.Log("OnGroundMove value" + inputValue);

        _stateFactory.CreateNextFactory();
    }
}
