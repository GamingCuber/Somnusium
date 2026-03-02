using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    public int currentQuestionIndex = 0;

    public int sleepAmount = 0;
    public string currentLevel;
}
