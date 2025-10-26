using System.Threading;
using UnityEngine;

public class ArrowMoviment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform myTransform;
    private float currentRotationTime = 0.0f;
    private float maxRotationTime = 1.0f;
    private float myInitialY;
    private float ScreenHeight;


    private void Start()
    {
        myTransform = GetComponent<Transform>();
        myInitialY  = myTransform.position.y;
        ScreenHeight = Screen.height;
        ScreenHeight = ScreenHeight / 1080f;
    }
    // Update is called once per frame
    void Update()
    {
        currentRotationTime += Time.deltaTime;
        float t = currentRotationTime / maxRotationTime;

        t = t - (int)t;
        if(t > 0.5f)
        {
            myTransform.position = new Vector3(myTransform.position.x, myInitialY + (ScreenHeight * (1 - t)), myTransform.position.z);
        }
        else 
        {
            myTransform.position = new Vector3(myTransform.position.x, myInitialY + (ScreenHeight * t), myTransform.position.z);
        }
    }
}
