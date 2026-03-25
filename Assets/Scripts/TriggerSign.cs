using TMPro;
using UnityEngine;

public class TriggerSign : MonoBehaviour
{
    [SerializeField]
    private string signText;
    [SerializeField]
    private float distanceUntilText;
    public GameObject dialogueBox;
    public PlayerData playerData;
    public Transform playerPosition;
    void Start()
    {
        dialogueBox.SetActive(false);
    }

    private void Update()
    {
        GameObject closestSign = findClosestSign();
        float distance = Vector2.Distance(closestSign.transform.position, playerPosition.position);
        if (distance <= distanceUntilText)
        {
            playerData.signText = signText;
            dialogueBox.SetActive(true);
            dialogueBox.transform.GetChild(0).GetComponent<TMP_Text>().text = signText;
        } else
        {
            dialogueBox.SetActive(false);
        }

    }

    private GameObject findClosestSign()
    {
        GameObject[] signObjects = GameObject.FindGameObjectsWithTag("Sign");
        float closestDistance = 100000000000f;
        GameObject closestSign = null;
        for (int i = 0; i < signObjects.Length; i++)
        {
            float currentDistance = Vector2.Distance(signObjects[i].transform.position, playerPosition.position);
            if (currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                closestSign = signObjects[i];
            } else
            {
                break;
            }
            
        }

        return closestSign;
    }
}
