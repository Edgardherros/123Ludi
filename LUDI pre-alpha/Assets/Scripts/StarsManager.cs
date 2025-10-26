using UnityEngine;
public class StarsManager : MonoBehaviour
{    
    [SerializeField] public GameObject[] L1;
    [SerializeField] public GameObject[] L0;
    void Start()
    {
        CheckLevel1();
        CheckLevel0();        
        Debug.Log("Level 1 Stars: " + PlayerPrefs.GetInt("Level1Stars"));
        Debug.Log("Level 0 Stars: " + PlayerPrefs.GetInt("Level0Stars"));
    }
    void CheckLevel1()
    {
        for (int j = 0; j < PlayerPrefs.GetInt("Level1Stars"); j++)
        {
            L1[j].SetActive(true);
        }        
    }
    void CheckLevel0()
    {
        for (int j = 0; j < PlayerPrefs.GetInt("Level0Stars"); j++)
        {
            L0[j].SetActive(true);
        }
    }
}