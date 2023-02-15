using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelController : MonoBehaviour

{
    private int level = 1;
    private ProgrammsProgressBar programmsProgressBar;
    [SerializeField] private Text levelText;
    private void Awake()
    {
        programmsProgressBar = FindObjectOfType<ProgrammsProgressBar>();
    }
    void Start()
    {
        
    }

    
    private void Update()
    {
        if (programmsProgressBar.IsProgrammsReady())
        {
            level++;
            levelText.text = "Level: " + level.ToString();
        }
    }
}
