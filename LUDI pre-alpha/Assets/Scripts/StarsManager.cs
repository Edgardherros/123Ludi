using UnityEngine;
public class StarsManager : MonoBehaviour
{    
    [SerializeField] public GameObject[] L1;
    void Start()
    {
        PlayerPrefs.SetInt("Level1Stars", 3);
        CheckLevel1();
    }
    void CheckLevel1()
    {
        for(int i = 0;i < PlayerPrefs.GetInt("Level1Stars"); i++)
        {
            L1[i].SetActive(true);      
        }
    }
}