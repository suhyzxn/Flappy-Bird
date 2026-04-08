using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider SFXSlider;
    [SerializeField] Slider BGMSlider;
    
    void Awake()
    {
        if (PlayerPrefs.HasKey("SFX"))
        {
            SFXSlider.value = PlayerPrefs.GetFloat("SFX");
        }
        
        if (PlayerPrefs.HasKey("BGM"))
        {
            BGMSlider.value = PlayerPrefs.GetFloat("BGM");
        }
        
        SFXSlider.onValueChanged.AddListener(SetSFX);
        BGMSlider.onValueChanged.AddListener(SetBGM);
    }

    void SetSFX(float volume)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFX", volume);
    }

    void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("BGM", volume);
    }

    public void OptionSound()
    {
        AudioSource optionSFX = GetComponent<AudioSource>();
        AudioClip optionClip = optionSFX.clip;
        optionSFX.PlayOneShot(optionClip);
    }
}
