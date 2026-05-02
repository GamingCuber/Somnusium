using UnityEngine;
using UnityEngine.SceneManagement;

public class DecisionScreenManager : MonoBehaviour
{
    public PlayerData playerData;
    public void OnDepriveButton()
    {
        playerData.sleepCounter -= playerData.deprivationAmount;
        OnMainMenuButton();
    }

    public void OnSleepButton()
    {
        OnMainMenuButton();
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
}
