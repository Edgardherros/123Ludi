using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void GoToMainTitle()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void ResetLevel0()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void ResetLevel1()
    {
        SceneManager.LoadSceneAsync(2);
    }

}
