using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    public void onQuit()
    {
        Application.Quit();
    }

    public void onStart()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void onCreditsOpen()
    {
        SceneManager.LoadScene("Credits");
    }
}
