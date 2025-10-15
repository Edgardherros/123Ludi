using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AdioSetings : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider mySlider;
    [SerializeField] private Slider mySlider2;
    [SerializeField] private Slider mySlider3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadMusicValue();
        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            LoadSFXValue();
        }
        if (PlayerPrefs.HasKey("GeneralVolume"))
        {
            LoadGeneralValue();
        }
        else
        {
            SetMusicVolume();
            SetSFXVolume();
            SetGeneralVolume();
        }
    }
    public void SetMusicVolume()
    {
        float volume = mySlider.value;
        audioMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);

    }
    public void SetSFXVolume()
    {
        float volume = mySlider2.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);

    }
    public void SetGeneralVolume()
    {
        float volume = mySlider3.value;
        audioMixer.SetFloat("General", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("GeneralVolume", volume);

    }
    private void LoadMusicValue()
    {
        mySlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
    }
    private void LoadSFXValue()
    {
        mySlider2.value = PlayerPrefs.GetFloat("SFXVolume");
        SetSFXVolume();
    }
    private void LoadGeneralValue()
    {
        mySlider3.value = PlayerPrefs.GetFloat("GeneralVolume");
        SetGeneralVolume();
    }
}

