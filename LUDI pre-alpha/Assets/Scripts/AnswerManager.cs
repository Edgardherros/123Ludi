using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerManager : MonoBehaviour
{
    [SerializeField] QuestionManager questionManager;
    [SerializeField] TowerManager towerManager;
    [SerializeField] TotalAnswers totalAnswers;

    [SerializeField] GameObject question;
    [SerializeField] GameObject towers;
    [SerializeField] GameObject answers;

    [SerializeField] TextMeshProUGUI answer1Text;
    [SerializeField] TextMeshProUGUI answer2Text;
    [SerializeField] TextMeshProUGUI answer3Text;
    [SerializeField] TextMeshProUGUI answer4Text;

    [SerializeField] Image[] answerButtonsImage;

    [SerializeField] string[] semanticsQuestions1;
    [SerializeField] string[] semanticsQuestions2;
    [SerializeField] string[] semanticsQuestions3;
    [SerializeField] string[] semanticsQuestions4;
    [SerializeField] string[] grammarQuestions1;
    [SerializeField] string[] grammarQuestions2;
    [SerializeField] string[] grammarQuestions3;
    [SerializeField] string[] grammarQuestions4;
    [SerializeField] string[] ortographyQuestions1;
    [SerializeField] string[] ortographyQuestions2;
    [SerializeField] string[] ortographyQuestions3;
    [SerializeField] string[] ortographyQuestions4;

    int rightAnswerPosition;

    const int maxQuestions = 5;

    int questionsAnswered = 0;
    public int rightAnswered = 0;

    public void setAnswers(TowerManager.TowerType type, int position)
    {
        List<string> tempList = new List<string>();
        switch (towerManager.currentTower)
        {
            case TowerManager.TowerType.semantica:
                tempList = new List<string> { semanticsQuestions1[position], semanticsQuestions2[position], semanticsQuestions3[position], semanticsQuestions4[position] };

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    string temp = tempList[i];
                    int rand = Random.Range(i, tempList.Count);
                    tempList[i] = tempList[rand];
                    tempList[rand] = temp;
                }
                answer1Text.text = tempList[0];
                answer2Text.text = tempList[1];
                answer3Text.text = tempList[2];
                answer4Text.text = tempList[3];

                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] == semanticsQuestions1[position])
                    {
                        rightAnswerPosition = i + 1;
                    }
                }

                break;
            case TowerManager.TowerType.lexico:
                tempList = new List<string> { grammarQuestions1[position], grammarQuestions2[position], grammarQuestions3[position], grammarQuestions4[position] };

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    string temp = tempList[i];
                    int rand = Random.Range(i, tempList.Count);
                    tempList[i] = tempList[rand];
                    tempList[rand] = temp;
                }
                answer1Text.text = tempList[0];
                answer2Text.text = tempList[1];
                answer3Text.text = tempList[2];
                answer4Text.text = tempList[3];

                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] == grammarQuestions1[position])
                    {
                        rightAnswerPosition = i + 1;
                    }
                }

                break;
            case TowerManager.TowerType.ortografia:
                tempList = new List<string> { ortographyQuestions1[position], ortographyQuestions2[position], ortographyQuestions3[position], ortographyQuestions4[position] };

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    string temp = tempList[i];
                    int rand = Random.Range(i, tempList.Count);
                    tempList[i] = tempList[rand];
                    tempList[rand] = temp;
                }
                answer1Text.text = tempList[0];
                answer2Text.text = tempList[1];
                answer3Text.text = tempList[2];
                answer4Text.text = tempList[3];

                for (int i = 0; i < tempList.Count; i++)
                {
                    if (tempList[i] == ortographyQuestions1[position])
                    {
                        rightAnswerPosition = i + 1;
                    }
                }

            break;
        }
    }

    public void chosenAnswer(int position)
    {
        
        questionsAnswered++;

        if (position == rightAnswerPosition)
        {
            rightAnswered++;
            answerButtonsImage[position - 1].color = Color.green;
            totalAnswers.answerWasCorrect();
        }
        else
        {
            answerButtonsImage[position - 1].color = Color.red;
        }
        
        
        if (questionsAnswered < maxQuestions)
        {
            questionManager.setQuestion();

        }
        else
        {
            question.SetActive(false);
            towers.SetActive(true);
            answers.SetActive(false);

            

            checkTowerResults();
        }
    }

    void checkTowerResults()
    {
        Debug.Log("Right answers: " + rightAnswered);
        towerManager.reactivateTowers();
        
        questionsAnswered = 0;
        questionsAnswered = 0;
    }
    
}
