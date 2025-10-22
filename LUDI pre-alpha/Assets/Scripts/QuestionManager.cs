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

    [HideInInspector] public bool[] answeredSemanticsQuestions;
    [HideInInspector] public bool[] answeredGrammarQuestions;
    [HideInInspector] public bool[] answeredOrtographyQuestions;

    private void Start()
    {
        answeredSemanticsQuestions = new bool[semanticsQuestions.Length];
        answeredGrammarQuestions = new bool[grammarQuestions.Length];
        answeredOrtographyQuestions = new bool[ortographyQuestions.Length];
    }

    public void setQuestion()
    {
        int chosenQuestion;
        bool repeat;
        switch (towerManager.currentTower)
        {
            case TowerManager.TowerType.semantica:
                
                repeat = true;
                while (repeat)
                {
                    chosenQuestion = Random.Range(0, semanticsQuestions.Length);
                    question.text = semanticsQuestions[chosenQuestion];
                    answerManager.setAnswers(TowerManager.TowerType.semantica, chosenQuestion);

                    if (!answeredSemanticsQuestions[chosenQuestion])
                    {
                        answeredSemanticsQuestions[chosenQuestion] = true;
                        repeat = false;
                    }
                }


                break;
            case TowerManager.TowerType.lexico:
                
                repeat = true;
                while (repeat)
                {
                    chosenQuestion = Random.Range(0, grammarQuestions.Length);
                    question.text = grammarQuestions[chosenQuestion];
                    answerManager.setAnswers(TowerManager.TowerType.lexico, chosenQuestion);

                    if (!answeredGrammarQuestions[chosenQuestion])
                    {
                        answeredGrammarQuestions[chosenQuestion] = true;
                        repeat = false;
                    }
                }


                break;
            case TowerManager.TowerType.ortografia:
                
                repeat = true;
                while (repeat)
                {
                    chosenQuestion = Random.Range(0, ortographyQuestions.Length);
                    question.text = ortographyQuestions[chosenQuestion];
                    answerManager.setAnswers(TowerManager.TowerType.ortografia, chosenQuestion);

                    if (!answeredOrtographyQuestions[chosenQuestion])
                    {
                        answeredOrtographyQuestions[chosenQuestion] = true;
                        repeat = false;
                    }
                }

                break;
        }

        

    }
}
