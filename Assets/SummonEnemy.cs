using UnityEngine;

public class SummonEnemy : MonoBehaviour
{

    [SerializeField]
    private Vector2[] enemyPositions;
    [SerializeField]
    private GameObject[] enemyList;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("trigger");
            for (int i = 0; i < enemyList.Length; i++)
            {
                Instantiate(enemyList[i], enemyPositions[i], Quaternion.identity);
            }
        }
    }
}
