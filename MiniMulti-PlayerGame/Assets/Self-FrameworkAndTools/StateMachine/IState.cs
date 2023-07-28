using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniMultiPlayerGame.StateMachine
{
    public interface IState
    {
        public void OnStateEnter();
        public void OnStateUpdate();
        public void OnStateExit();
    }
}

