using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Rigidbody2D enemyBody;
    public Collider2D enemyCollider;

    public float horizontalOffset = 10f;
    public float verticalOffset = 10f;
    public float maxposx;
    public float maxposy;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxposx = transform.position.x + horizontalOffset;
        maxposy = transform.position.x + verticalOffset;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
