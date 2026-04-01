using UnityEngine;
using UnityEngine.SceneManagement;

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
    public void OnMainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void nextLevel()
    {
        // TODO
    }
}
