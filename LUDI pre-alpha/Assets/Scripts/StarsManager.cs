using UnityEngine;
using UnityEngine.UI;

public class StarsManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] public GameObject[] L1;
    void Start()
    {
        
        PlayerPrefs.SetInt("Level1Stars", 3);
        CheckLevel1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CheckLevel1()
    {
        for(int i = L1.Length; i >0; i--)
        {
            if (i == 0)
                break;
            if (PlayerPrefs.GetInt("Level1Stars") == i)
            {
                // Hacer que se activen las estrellas hacia arriba
                L1[i - 1].SetActive(true);
                
            }
        
        }
    }
}
