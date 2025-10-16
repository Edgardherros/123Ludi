using UnityEngine;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{

    [HideInInspector] public bool selectingTower;
    [SerializeField] AnswerManager answerManager;
    [SerializeField] QuestionManager questionManager;

    [SerializeField] Button tower1;
    [SerializeField] Button tower2;
    [SerializeField] Button tower3;


    public bool tower1Cleared = false;
    public bool tower2Cleared = false;
    public bool tower3Cleared = false;

    public enum TowerType
    {
        semantica, lexico, ortografia, none
    }
    [HideInInspector] public TowerType currentTower;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectingTower = true;
        
    }

    // Update is called once per frame


    public void towerHasBeenChosen(int towerNumber)
    {
        
        switch (towerNumber)
        {
            case 1:
                currentTower = TowerType.semantica;
                tower1Cleared = true;
                break;
            case 2:
                currentTower = TowerType.lexico;
                tower2Cleared = true; 
                break;
            case 3:
                currentTower = TowerType.ortografia;
                tower3Cleared = true;

                break;
            default:
                Debug.LogError("ERROR: 'towerHasBeenChosen' HAS AN INCORRECT VALUE GIVEN THE CONTEXT");
                break;
        }
        questionManager.setQuestion();
        
    }

    public void reactivateTowers()
    {
        if (tower1Cleared)
            tower1.interactable = false;
        else
            tower1.interactable = true;
        if (tower2Cleared)
            tower2.interactable = false;
        else
            tower2.interactable = true;
        if (tower3Cleared)
            tower3.interactable = false;
        else
            tower3.interactable = true;
        
        currentTower = TowerType.none;
    }
}