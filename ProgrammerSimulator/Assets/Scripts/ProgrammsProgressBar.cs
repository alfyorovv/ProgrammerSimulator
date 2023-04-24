using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgrammsProgressBar : MonoBehaviour
{
    [SerializeField] private Image programmsProgressBar;
    [SerializeField] private int targetProgramms;
    [SerializeField] private Text programmsText;
    private TapsProgressBar tapsProgressBar;
    
    private void Awake()
    {
        tapsProgressBar = FindObjectOfType<TapsProgressBar>();
        programmsText.text = PlayerPrefs.GetInt("targetProgramms").ToString();
        targetProgramms = PlayerPrefs.GetInt("targetProgramms");
        programmsProgressBar.fillAmount = PlayerPrefs.GetInt("programms") / (float)PlayerPrefs.GetInt("targetProgramms");
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
        PlayerPrefs.SetInt("programms", PlayerPrefs.GetInt("programms")+1);
        programmsProgressBar.fillAmount = PlayerPrefs.GetInt("programms") / (float)PlayerPrefs.GetInt("targetProgramms");
    }

    public bool IsProgrammsReady()
    {
        if (PlayerPrefs.GetInt("programms") == PlayerPrefs.GetInt("targetProgramms"))
        {
            PlayerPrefs.SetInt("programms", 0);
            programmsProgressBar.fillAmount = 0;
            PlayerPrefs.SetInt("targetProgramms", PlayerPrefs.GetInt("targetProgramms")+15);
            programmsText.text = PlayerPrefs.GetInt("targetProgramms").ToString();
            return true;
        }
        else
            return false;

    }
}
