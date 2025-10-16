using UnityEngine;
using UnityEngine.UI;

public class ButtonColorReset : MonoBehaviour
{
    const float colorResetValue = 0.5f;

    Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color += new Color(colorResetValue * Time.deltaTime, colorResetValue * Time.deltaTime, colorResetValue * Time.deltaTime, 1);
    }
}
