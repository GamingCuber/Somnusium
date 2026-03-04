using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public int currentQuestionIndex = 0;

    public int sleepCounter = 0;
    public int deprivationAmount;
    public int sleepingAmount;
    public string currentLevel;
}
