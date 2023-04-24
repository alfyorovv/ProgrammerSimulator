using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public int level = 0;
    private ProgrammsProgressBar programmsProgressBar;
    private MessageController messageController;
    [SerializeField] private Text levelText;
    [SerializeField] private string[] levels;
    [SerializeField] private string[] companies;
    [SerializeField] private GameObject message;
    [SerializeField] private Transform emailPanel;


    private void Awake()
    {
        programmsProgressBar = FindObjectOfType<ProgrammsProgressBar>();
        messageController = FindObjectOfType<MessageController>();
        levelText.text = "Level: " + levels[level];
    }
    
    private void Update()
    {
        if (programmsProgressBar.IsProgrammsReady())
        {
            level++;
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + messageController.currentSalary);
            levelText.text = "Level: " + levels[level];

            for (int i = 0; i < 3; i++)
            {
                message.GetComponentInChildren<Text>().text = "Company " + companies[Random.Range(0,companies.Length)] +  " has invited you for a job. Require level: " + levels[level] + ". Salary: $" + messageController.salary;
                Instantiate(message, emailPanel);
            }
            
        }
    }
}
