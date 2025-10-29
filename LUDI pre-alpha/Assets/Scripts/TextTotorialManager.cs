using TMPro;
using UnityEngine;

public class TextTotorialManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] string[] DialogoTutorial;
    private int indiceDialogo = 0;
    private int totalDialogos;
    private bool tutorialIniciado = false;
    [SerializeField] TextMeshProUGUI question;
    [SerializeField] GameObject Tutorial;
    [SerializeField] GameObject Lemur;
    [SerializeField] GameObject Serpiente;
    [SerializeField] GameObject Perry;
    [SerializeField] GameObject Flechas;
    [SerializeField] GameObject LemurPant;
    [SerializeField] GameObject SerpientePant;
    [SerializeField] GameObject PerryPant;

    private void Start()
    {
        totalDialogos = DialogoTutorial.Length;
        LemurPant.SetActive(false);
        SerpientePant.SetActive(false); 
        PerryPant.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        question.text = DialogoTutorial[indiceDialogo];
        if(indiceDialogo == 2)
        {
            Serpiente.SetActive(false);
            Perry.SetActive(false);
        }
        if(indiceDialogo == 4)
        {
            Lemur.SetActive(false);
            Serpiente.SetActive(false);
            Perry.SetActive(true);
        }
        if (indiceDialogo == 6)
        {
            Lemur.SetActive(false);
            Serpiente.SetActive(true);
            Perry.SetActive(false);
        }

    }
    public void CheckEnd()
    {
        if(tutorialIniciado)
        {
            Tutorial.SetActive(false);
            Flechas.SetActive(true);
            LemurPant.SetActive(true);
            SerpientePant.SetActive(true);
            PerryPant.SetActive(true);
        }
        else
        {
            if(indiceDialogo >= (totalDialogos -1))
            {
                
                tutorialIniciado = true;
            }
            else
            {
                indiceDialogo++;
            }
        }
    }

}
