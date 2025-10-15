using UnityEngine;

public class TowerManager : MonoBehaviour
{

    [HideInInspector] public bool selectingTower;
    [SerializeField] AnswerManager answerManager;
    [SerializeField] QuestionManager questionManager;

    [SerializeField] GameObject towerContainer;
    [SerializeField] GameObject tower1;
    [SerializeField] GameObject tower2;
    [SerializeField] GameObject tower3;

    public bool tower1Cleared;
    public bool tower2Cleared;
    public bool tower3Cleared;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectingTower = true;
    }

    // Update is called once per frame
    

    public void pickedTower()
    {
        towerContainer.SetActive(false);
        questionManager.showQuestions();
        answerManager.showAnswers();
    }

    public void reactivateTowers()
    {
        towerContainer.SetActive(true);
    }
}
