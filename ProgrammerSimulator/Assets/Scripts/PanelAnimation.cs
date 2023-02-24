using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelAnimation : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void OpenClosePanel()
    {
        animator.SetTrigger("PanelTrigger");
    }
  
}
