using UnityEngine;

public class DecisionScreenManager : MonoBehaviour
{
    public PlayerData playerData;
    public void OnDepriveButton()
    {
        playerData.sleepCounter -= playerData.deprivationAmount;
    }

    public void OnSleepButton()
    {
        playerData.sleepCounter += playerData.sleepingAmount;
    }

    private void nextLevel()
    {
        // TODO
    }
}
