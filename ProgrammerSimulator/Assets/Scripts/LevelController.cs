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
    [SerializeField] private string[] companies;
    [SerializeField] private GameObject message;
    [SerializeField] private Transform emailPanel;


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

            for (int i = 0; i < 3; i++)
            {
                int salary = level * Random.Range(100,150);

                message.GetComponentInChildren<Text>().text = "Company " + companies[Random.Range(0,companies.Length)] +  " has invited you for a job. Require level: " + levels[level] + ". Salary: $"+salary;
                Instantiate(message, emailPanel);
            }
            
        }
    }
}
