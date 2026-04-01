using UnityEngine;

public class SummonEnemy : MonoBehaviour
{
    private bool summonedEnemies;
    [SerializeField]
    private Vector2[] enemyPositions;
    [SerializeField]
    private GameObject[] enemyList;

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !summonedEnemies)
        {
            summonedEnemies = true;
            for (int i = 0; i < enemyList.Length; i++)
            {
                Instantiate(enemyList[i], enemyPositions[i], Quaternion.identity);
            }
        }
    }
}
