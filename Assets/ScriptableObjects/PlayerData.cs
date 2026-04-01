using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public bool hasPencil;
    public int damageDealt;

    public int currentQuestionIndex;

    public int sleepCounter = 0;
    public int deprivationAmount;
    public int sleepingAmount;
    public string currentLevel;
    public string signText;
}
