using MiniMultiPlayerGame.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine : MonoBehaviour
{
    private IState _currentState;

    void Start()
    {
        // setup for current state
    }

    void Update()
    {
        if(_currentState != null)
        {
            _currentState.OnStateUpdate();
        }
    }

    private void OnStateChange(IState state)
    {
        if (_currentState != null)
            _currentState.OnStateExit();

        _currentState = state;
        _currentState.OnStateEnter();
    }
}
