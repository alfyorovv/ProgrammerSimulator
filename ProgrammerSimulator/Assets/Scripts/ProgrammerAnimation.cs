using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgrammerAnimation : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>(); 
    }

    public void AnimationNextFrame()
    {
        animator.Play(0, -1, (animator.GetCurrentAnimatorStateInfo(0).normalizedTime + Time.deltaTime) % 1);

    }
    
}
