using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniMultiPlayerGame.StateMachine 
{
    public class StateMachine : MonoBehaviour 
    {
        [SerializeField] private IState _currentState;

        public Action<IState> ChangeStateAction;

        #region Unity default
        private void Awake()
        {
            ChangeStateAction += OnStateChanged;
        }

        private void Update() 
        {
            if (_currentState != null)
                _currentState.OnStateUpdate();
        }

        private void OnDestroy()
        {
            ChangeStateAction -= OnStateChanged;
        }
        #endregion

        #region State framework function
        private void OnStateChanged(IState nextState) {
            if(_currentState != null)
                _currentState.OnStateExit();

            _currentState = nextState;
            _currentState.OnStateEnter();
        }
        #endregion
    }
}
