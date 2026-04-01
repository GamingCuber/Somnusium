using JetBrains.Annotations;
using Unity.IntegerTime;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D MyRb;
    public float speed;
    public float health;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.timeScale == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);    
        }
    }

    public void hurtEnemy(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
