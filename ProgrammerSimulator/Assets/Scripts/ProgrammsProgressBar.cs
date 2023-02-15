using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgrammsProgressBar : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image programmsProgressBar;
    [SerializeField] private int targetProgramms = 10;
    private TapsProgressBar tapsProgressBar;
    private int programms = 0;

    private void Awake()
    {
        tapsProgressBar = FindObjectOfType<TapsProgressBar>();
    }
    void Start()
    {
        
    }

  private void Update()
    {
        if (tapsProgressBar.IsProgrammReady())
        {
            FillingProgressBar();
        }
    }
    public void FillingProgressBar()
    {
        programms++;
        programmsProgressBar.fillAmount = programms / (float)targetProgramms;
    }

    public bool IsProgrammsReady()
    {
        if (programms == targetProgramms)
        {
            programms = 0;
            programmsProgressBar.fillAmount = 0;
            return true;
        }
        else
            return false;

    }
}
