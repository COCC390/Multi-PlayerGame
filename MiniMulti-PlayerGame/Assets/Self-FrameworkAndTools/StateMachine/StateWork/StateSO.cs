using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniMultiPlayerGame.StateMachine 
{
    [CreateAssetMenu(fileName = "NewState", menuName = "StateSO/OriginalState")]
    public class StateSO : ScriptableObject
    {
        public IStateTask _task;
        
        public void ExecuteTask() {
            _task.ExecuteTask();
        }
    }
}
