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

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            playerData.currentLevel = SceneManager.GetActiveScene().name;
            // int difficulty = playerData.sleepCounter / 20;
            playerData.currentQuestionIndex = questionType - 1;
            // + (difficulty) * 5;
            SceneManager.LoadScene("ProblemScene");

            Destroy(this);
        }
    }
}
