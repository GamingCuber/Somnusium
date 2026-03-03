using JetBrains.Annotations;
using Unity.IntegerTime;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D PlayerRb;
    public Rigidbody2D MyRb;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
          transform.position = Vector3.MoveTowards(transform.position, PlayerRb.transform.position, speed);    
        }
       
       
    }
}
