using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartLevel1()
    {
        SceneManager.LoadScene(2);
    }
    public void StartLevel0()
    {
        SceneManager.LoadScene(3);
    }
}











