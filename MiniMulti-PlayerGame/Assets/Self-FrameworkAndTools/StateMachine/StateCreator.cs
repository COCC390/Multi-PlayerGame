using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniMultiPlayerGame.StateMachine 
{
    public class StateCreator : MonoBehaviour 
    {
        [SerializeField] private List<ScriptableObject> _states; // save switch to state
        [SerializeField] private StateContext _currentStateContext;

        public IState CreateNextState(/*StateContext stateContext*/) 
        {
            IState nextState = null;

            return nextState;
        }
    }

    public enum StateContext {
        Default,
        OnGetDamaged,
        OnDizzy,
        OnLowMana,
        OnLowHealth
    }

    /* To switch to new state we can: 
     * PlayerInput + CurrentState + CurrentContext (known as condition) = NewState
     * CurrentState we can compare it to list state can switch to
     * CurrentContext we can compare it to list context can switch to
     */

    [System.Serializable]
    public struct SwitchToState {
        public IState switchState; // the state need to switch to
        public List<IState> statesCanSwitchTo;
        public List<StateContext> contextsCanSwitchTo;
    }
}
