using UnityEngine;
using UnityEngine.UI;

public class DelayPanel : MonoBehaviour
{
    [SerializeField] AnswerManager answerManager;
    float timer = 0;
    float delay = 1.5f;
    Image panel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel = GetComponent<Image>();
        panel.enabled = false;
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < delay)
        {
            timer += Time.deltaTime;
            if(timer >= delay)
            {
                panel.enabled = false;
                answerManager.updateQuestions();
            }
        }
    }

    public void activateDelay()
    {
        timer = 0;
        panel.enabled = true;
    }

}
