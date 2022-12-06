using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RL_Sound_Manager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        // the volume will be at 100% for default
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        // the volume of the game will be controlled via the slider
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        // this sets the volume depending of the value set before 
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        // saves the value of the slider
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
