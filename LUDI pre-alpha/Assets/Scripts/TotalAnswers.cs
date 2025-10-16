using TMPro;
using UnityEngine;

public class TotalAnswers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    const int totalAnswers = 15;
    private int currentAnswer = 0;
    [SerializeField] TextMeshProUGUI score;
    
    void Update()
    {
        score.text = currentAnswer + "/" + totalAnswers;
    }
    public void answerWasCorrect()
    {
        currentAnswer++;
       
    }
}
