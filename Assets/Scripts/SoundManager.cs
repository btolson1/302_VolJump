/* 
Brien, Brycen, Robert, Kush
Vol Jump Project
5/8/2023
SoundManager for Volume Slider
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void Start() {
        Load();
    }

    // Save the value of the slider after each run
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    // Load Saved Value
    private void Load() 
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume", 1);
    }

    private void Save() {

        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
