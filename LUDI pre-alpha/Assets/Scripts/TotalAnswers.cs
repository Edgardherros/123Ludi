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

    [SerializeField] Image[] progressBar;
    [SerializeField] Sprite rightAnswered;
    [SerializeField] Sprite notAnswered;
    
    [SerializeField] TextMeshProUGUI demiseText;
    [SerializeField] GameObject resultsPanel;
    [SerializeField] GameObject[] stars;

    private void Start()
    {
        resultsPanel.SetActive(false);
    }


    public void answerWasCorrect()
    {
        progressBar[answerManager.questionsAnswered-1].sprite = rightAnswered;
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
            int totalStars = 0;
            if (answerManager.rightAnswered == 15)
            {
               totalStars = 3;
            }
            else if (answerManager.rightAnswered >= 12)
            {
                totalStars = 2;
            }
            else if (answerManager.rightAnswered >= 9)
            {
               totalStars = 1;
            }
            for(int i = 0; i < totalStars; i++)
            {
                stars[i].SetActive(true);
            }
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

    public void SetStarsLevel0()
    {
        
        if (answerManager.rightAnswered == 15)
        {
            PlayerPrefs.SetInt("Level0Stars", 3);
        }
        else if (answerManager.rightAnswered >= 12)
        {
            if(PlayerPrefs.HasKey("Level0Stars") && PlayerPrefs.GetInt("Level0Stars") < 2)
            PlayerPrefs.SetInt("Level0Stars", 2);
            else if (!PlayerPrefs.HasKey("Level0Stars"))
                PlayerPrefs.SetInt("Level0Stars", 2);
        }
        else if (answerManager.rightAnswered >= 9)
        {
            if (PlayerPrefs.HasKey("Level0Stars") && PlayerPrefs.GetInt("Level0Stars") < 1)
                PlayerPrefs.SetInt("Level0Stars", 1);
            else if (!PlayerPrefs.HasKey("Level0Stars"))
                PlayerPrefs.SetInt("Level0Stars", 1);
        }
        else
        {
            if (PlayerPrefs.HasKey("Level0Stars") && PlayerPrefs.GetInt("Level0Stars") < 0)
                PlayerPrefs.SetInt("Level0Stars", 0);
            else if (!PlayerPrefs.HasKey("Level0Stars"))
                PlayerPrefs.SetInt("Level0Stars", 0);
        }

    }
    public void SetStarsLevel1()
    {

        if (answerManager.rightAnswered == 15)
        {
            PlayerPrefs.SetInt("Level1Stars", 3);
        }
        else if (answerManager.rightAnswered >= 12)
        {
            if (PlayerPrefs.HasKey("Level1Stars") && PlayerPrefs.GetInt("Level1Stars") < 2)
                PlayerPrefs.SetInt("Level1Stars", 2);
            else if (!PlayerPrefs.HasKey("Level1Stars"))
                PlayerPrefs.SetInt("Level1Stars", 2);
        }
        else if (answerManager.rightAnswered >= 9)
        {
            if (PlayerPrefs.HasKey("Level1Stars") && PlayerPrefs.GetInt("Level1Stars") < 1)
                PlayerPrefs.SetInt("Level1Stars", 1);
            else if (!PlayerPrefs.HasKey("Level1Stars"))
                PlayerPrefs.SetInt("Level1Stars", 1);
        }
        else
        {
            if (PlayerPrefs.HasKey("Level0Stars") && PlayerPrefs.GetInt("Level0Stars") < 0)
                PlayerPrefs.SetInt("Level1Stars", 0);
            else if (!PlayerPrefs.HasKey("Level1Stars"))
                PlayerPrefs.SetInt("Level1Stars", 0);
        }

    }

}
