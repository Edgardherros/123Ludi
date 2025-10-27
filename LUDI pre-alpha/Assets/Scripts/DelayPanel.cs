using UnityEngine;
using UnityEngine.UI;

public class DelayPanel : MonoBehaviour
{
    float timer = 0;
    float delay = 2;
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
            }
        }
    }

    public void activateDelay()
    {
        timer = 0;
        panel.enabled = true;
    }

}
