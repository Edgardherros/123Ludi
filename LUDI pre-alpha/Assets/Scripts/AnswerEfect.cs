using UnityEngine;
using UnityEngine.UI;

public class AnswerEfect : MonoBehaviour
{
    private Image image;
    private float t = 0f;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        t += Time.deltaTime / 125;
        image.color = new Color(1f, 1f, 1f, image.color.a - t);

        if (image.color.a <= 0)
        {
            Destroy(gameObject); 
        }

        
    }
}
