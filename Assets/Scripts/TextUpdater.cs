using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public PlayerData playerData;
    

    public void UpdateText()
    {
        GetComponent<TMP_Text>().text = playerData.signText;
    }
}
