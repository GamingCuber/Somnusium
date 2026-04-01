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
    private TMP_Text dialogueBoxText;
    void Start()
    {
        dialogueBoxText = dialogueBox.transform.GetChild(0).GetComponent<TMP_Text>();

        dialogueBox.SetActive(false);
    }

    private void Update()
    {
        GameObject closestSign = findClosestSign();
        float distance = Vector2.Distance(closestSign.transform.position, playerPosition.position);
        if (distance <= distanceUntilText)
        {
            if (closestSign.layer.Equals(LayerMask.NameToLayer("Pedestal")) && playerData.hasPencil)
            {  
                playerData.signText = "You picked it up! Press left click to attack!";
                signText = playerData.signText;
                dialogueBox.SetActive(true);
                dialogueBoxText.text = signText;

            } else
            {
                playerData.signText = signText;
                dialogueBox.SetActive(true);
                dialogueBoxText.text = signText;
            }
            
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
