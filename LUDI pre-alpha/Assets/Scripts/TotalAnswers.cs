using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TotalAnswers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    const int totalAnswers = 15;
    private int currentAnswer = 0;
    
    [SerializeField] AnswerManager answerManager;
    
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI demiseText;
    [SerializeField] GameObject resultsPanel;


    private void Start()
    {
        resultsPanel.SetActive(false);
    }

    void Update()
    {
        score.text = currentAnswer + "/" + totalAnswers;
    }
    public void answerWasCorrect()
    {
        currentAnswer++;
       
    }

    public void setResultsScreen()
    {
        if (answerManager.rightAnswered < 9)
        {
            demiseText.text = "You lost";
            demiseText.color = Color.red;
        }
        else
        {
            demiseText.text = "You Won!";
            demiseText.color = Color.green;
        }
        resultsPanel.SetActive(true);
    }


    public void restartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void goToTitleScreen()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
