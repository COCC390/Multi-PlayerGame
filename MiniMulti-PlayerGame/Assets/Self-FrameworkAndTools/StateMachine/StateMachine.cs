using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniMultiPlayerGame.StateMachine 
{
    public class StateMachine : MonoBehaviour 
    {
        [SerializeField] private IState _currentState;
        [SerializeField] private StateContext _currentStateContext;
        // save a manage help to return next state

        private void Update() 
        {
            if (_currentState != null)
                _currentState.OnStateUpdate();
        }

        private void OnStateChanged(IState nextState) {
            if(_currentState != null)
                _currentState.OnStateExit();

            _currentState = nextState;
            _currentState.OnStateEnter();
        }
    }
}
