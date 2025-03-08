using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;



public class settingsWindow : MonoBehaviour
{
    // Start is called before the first frame update
    
    
   
    public TMP_InputField inputField;
    public string newTXT;
    public Slider masterVolumeSlider;
    public Slider musicSlider;
    public AudioMixer audioMixer;
    public Slider SFXSlIder;
    public TMP_Text player;
    

    void Start()
    {
        
        newTXT = PlayerPrefs.GetString("NamePlayer");
        inputField.text = newTXT;
        masterVolumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        SFXSlIder.value = PlayerPrefs.GetFloat("SFXVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.HasKey("TEXT"))
        {
            player.text = PlayerPrefs.GetString("TEXT");
        }
    }
    public void VolmeCH()
    {
        audioMixer.SetFloat("MasterVolume", masterVolumeSlider.value);
        PlayerPrefs.SetFloat("MasterVolume", masterVolumeSlider.value);
        

    }

    public void InputF()
    {
        PlayerPrefs.SetString("NamePlayer", inputField.text.ToString());

        
    }
    public void VolmeCHMusic()
    {
        audioMixer.SetFloat("MusicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }
    public void VolmeCHSFX()
    {
        audioMixer.SetFloat("SFXVolume", SFXSlIder.value);
        PlayerPrefs.SetFloat("SFXVolume", SFXSlIder.value);
    }

    }
