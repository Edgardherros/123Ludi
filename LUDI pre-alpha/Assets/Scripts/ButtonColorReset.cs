using UnityEngine;
using UnityEngine.UI;

public class ButtonColorReset : MonoBehaviour
{
    const float colorResetValue = 2.5f;

    Image image;
    void Awake()
    {
        image = GetComponent<Image>();
        image.color = new Color(255, 255, 255, 1);
    }

    // Update is called once per frame
    void Update()
    {
        image.color += new Color(colorResetValue * Time.deltaTime, colorResetValue * Time.deltaTime, colorResetValue * Time.deltaTime, 1);
    }
}
