using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MessageController : MonoBehaviour
{
    public int salary;
    public int currentSalary = 0;
    private LevelController levelController;

    private void Awake()
    {
        levelController = FindObjectOfType<LevelController>();
        salary = levelController.level * Random.Range(100, 150);
    }

    public void DeleteMessage()
    {
        Destroy(gameObject);
    }

    public void AcceptInvitation()
    {
        currentSalary = salary;
    }
}
