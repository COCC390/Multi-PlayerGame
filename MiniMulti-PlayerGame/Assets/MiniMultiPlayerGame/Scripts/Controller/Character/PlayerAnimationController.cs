using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerAnim
{
    Idle,
    Walk
}

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationPlay(string animName)
    {
        Debug.Log("run anim: ");
        _anim.Play(animName);
    }

    public void AnimationStop()
    {

    }

    private void OnAnimationPlay(Animation animation) => animation.Play();
}
