using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{

    public Rigidbody2D enemyBody;
    public Collider2D enemyCollider;
    public PlayerData playerData;
    private int questionType;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random rng = new System.Random();
        /*  1: Math  
            2: English
            3: History
        */
        questionType = rng.Next(1, 3);
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            playerData.currentLevel = SceneManager.GetActiveScene().name;
            int difficulty = playerData.sleepAmount / 20;
            playerData.currentQuestionIndex = questionType + (difficulty) * 5;
            playerData.currentQuestionIndex = 0;


            Debug.Log("question type" + questionType);
            Debug.Log("difficulty" + difficulty);
            Debug.Log("current question" + playerData.currentQuestionIndex);
            SceneManager.LoadScene("ProblemScene");

            Destroy(this);
        }
    }
}
