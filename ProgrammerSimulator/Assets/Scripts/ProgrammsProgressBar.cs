using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgrammsProgressBar : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Image programmsProgressBar;
    [SerializeField] private int targetProgramms = 10;
    [SerializeField] private Text programmsText;
    private TapsProgressBar tapsProgressBar;
    private int programms = 0;

    private void Awake()
    {
        tapsProgressBar = FindObjectOfType<TapsProgressBar>();
        programmsText.text = targetProgramms.ToString();

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
            targetProgramms += 15;
            programmsText.text = targetProgramms.ToString();
            return true;
        }
        else
            return false;

    }
}
