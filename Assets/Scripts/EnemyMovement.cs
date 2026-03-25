using JetBrains.Annotations;
using Unity.IntegerTime;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D PlayerRb;
    public Rigidbody2D MyRb;
    public float speed;
    public float health;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.timeScale == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerRb.transform.position, speed);    
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
