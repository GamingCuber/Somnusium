using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class SwingScript : MonoBehaviour
{
    [SerializeField]
    private float timeOut;
    [SerializeField]
    private float coolDownTime;
    [SerializeField]
    private float distanceFromPlayer;
    private bool canSwing;
    private bool isSwinging;
    // Left: 0, Up: 1, Right: 2, Down: 3
    private int currentDirection;
    public PlayerData playerData;
    private GameObject player;
    private Vector2 weaponPosition;

    void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        weaponPosition = new Vector2();
        canSwing = true;
    }

    void Update()
    {
        checkDirection();
        switch (currentDirection)
        {
            case 0:
                weaponPosition = player.transform.position + (Vector3) Vector2.left * distanceFromPlayer;
                break;
            case 1:
                weaponPosition = player.transform.position + (Vector3) Vector2.up * distanceFromPlayer;
                break;
            case 2:
                weaponPosition = player.transform.position + (Vector3) Vector2.right * distanceFromPlayer;
                break;
            case 3:
                weaponPosition = player.transform.position +  (Vector3) Vector2.down * distanceFromPlayer;
                break;            
        }
        transform.position = weaponPosition;
        if (Input.GetKeyDown(KeyCode.Mouse0) && !isSwinging && canSwing)
        {
            isSwinging = true;
            Invoke(nameof(stopSwing), timeOut);
        }
        gameObject.GetComponent<BoxCollider2D>().enabled = isSwinging;
        gameObject.GetComponent<SpriteRenderer>().enabled = isSwinging;

    }

    private void stopSwing()
    {
        canSwing = false;
        isSwinging = false;
        Invoke(nameof(enableSwinging), coolDownTime);
    }

    private void enableSwinging()
    {
        
        canSwing = true;
    }

    private void checkDirection()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentDirection = 1;
        }
         if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentDirection = 0;
        }
         if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentDirection = 3;
        }
         if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentDirection = 2;
        }
    }

    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.layer.Equals(LayerMask.NameToLayer("Destructible")))
        {
            collision.gameObject.GetComponent<LightbulbDrop>().dropItem();
        }
        else if (collision.gameObject.layer.Equals(LayerMask.NameToLayer("Enemy")))
        {
            collision.gameObject.GetComponent<EnemyMovement>().hurtEnemy(playerData.damageDealt);
        }
    }
    
}
