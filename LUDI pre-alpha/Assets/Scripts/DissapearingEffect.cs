using UnityEngine;
using UnityEngine.UI;
public class DissapearingEffect : MonoBehaviour
{
    const float colorResetValue = 0.5f;

    SpriteRenderer image;
    void Awake()
    {
        image = GetComponent<SpriteRenderer>();
        transform.localScale = Vector3.one * 6;
    }

    // Update is called once per frame
    void Update()
    {
        image.color -= new Color(0, 0, 0, colorResetValue * Time.deltaTime);
        if(image.color.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}
