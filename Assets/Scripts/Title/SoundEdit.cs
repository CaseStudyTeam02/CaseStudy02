using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEdit : MonoBehaviour {

    public Slider BGMSlider;
    public Slider SESlider;
    public Slider VoiceSlider;

    static float volume = 100;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBGMVolume()
    {
        SoundManager.SetBGMVolume(BGMSlider.value / 100.0f);
    }

    public void ChangeSEVolume()
    {
        SoundManager.SetSEVolume(SESlider.value / 100.0f);
    }

    public void ChangeVoiceVolume()
    {
        SoundManager.SetVoiceVolume(VoiceSlider.value / 100.0f);
    }
}
