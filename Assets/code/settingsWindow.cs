using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;



public class settingsWindow : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource music;
    
    public Dropdown Language;
    public TMP_InputField inputField;
    public string newTXT;
    public Slider MasterVolumeSlider;
    public Slider MusicSlider;
    public AudioMixer audioMixer;
    public Slider SFX;
    

    void Start()
    {
        
        newTXT = PlayerPrefs.GetString("TEXT");
        inputField.text = newTXT;
        MasterVolumeSlider.value = PlayerPrefs.GetFloat("volumeMusic");
        SFX.value = PlayerPrefs.GetFloat("SFX");
        MusicSlider.value = PlayerPrefs.GetFloat("MusicSlider");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void volmeCH()
    {
        audioMixer.SetFloat("Master", MasterVolumeSlider.value);
        PlayerPrefs.SetFloat("volumeMusic", MasterVolumeSlider.value);
        

    }

    public void inputF()
    {
        PlayerPrefs.SetString("TEXT", inputField.text.ToString());

        
    }
    public void volmeCHMusic()
    {
        audioMixer.SetFloat("Music", MusicSlider.value);
        PlayerPrefs.SetFloat("MusicSlider", MusicSlider.value);
    }
    public void volmeCHSFX()
    {
        audioMixer.SetFloat("SFX", SFX.value);
        PlayerPrefs.SetFloat("SFX", SFX.value);
    }

    }
