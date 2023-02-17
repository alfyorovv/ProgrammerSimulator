using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelController : MonoBehaviour

{
    private int level = 0;
    private ProgrammsProgressBar programmsProgressBar;
    [SerializeField] private Text levelText;
    [SerializeField] private string[] levels;
    private void Awake()
    {
        programmsProgressBar = FindObjectOfType<ProgrammsProgressBar>();
        levelText.text = "Level: " + levels[level];
    }
    
    private void Update()
    {
        if (programmsProgressBar.IsProgrammsReady())
        {
            level++;
            levelText.text = "Level: " + levels[level];
        }
    }
}
