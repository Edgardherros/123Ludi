using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] AnswerManager answerManager;
    [SerializeField] TowerManager towerManager;

    [SerializeField] TextMeshProUGUI question;

    [SerializeField] string[] semanticsQuestions;
    [SerializeField] string[] grammarQuestions;
    [SerializeField] string[] ortographyQuestions;
    
    

    public void setQuestion()
    {
        int chosenQuestion;

        switch (towerManager.currentTower)
        {
            case TowerManager.TowerType.semantica:
                
                chosenQuestion = Random.Range(0, semanticsQuestions.Length);
                question.text = semanticsQuestions[chosenQuestion];
                answerManager.setAnswers(TowerManager.TowerType.semantica, chosenQuestion);

                break;
            case TowerManager.TowerType.lexico:
                
                chosenQuestion = Random.Range(0, grammarQuestions.Length);
                question.text = grammarQuestions[chosenQuestion];
                answerManager.setAnswers(TowerManager.TowerType.lexico, chosenQuestion);

                break;
            case TowerManager.TowerType.ortografia:
                
                chosenQuestion = Random.Range(0, ortographyQuestions.Length);
                question.text = ortographyQuestions[chosenQuestion];
                answerManager.setAnswers(TowerManager.TowerType.ortografia, chosenQuestion);

                break;
        }

        

    }
}
