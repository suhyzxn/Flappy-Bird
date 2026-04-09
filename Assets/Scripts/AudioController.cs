using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider SFXSlider;
    [SerializeField] Slider BGMSlider;
    [SerializeField] AudioSource bgm;
    
    void Awake()
    {
        SFXSlider.onValueChanged.RemoveAllListeners();
        BGMSlider.onValueChanged.RemoveAllListeners();
    }

    void Start()
    {
        SFXSlider.value = PlayerPrefs.GetFloat("SFX", 0.7f);
        SetSFX(SFXSlider.value);
    
        BGMSlider.value = PlayerPrefs.GetFloat("BGM", 0.7f);
        SetBGM(BGMSlider.value);
        
        SFXSlider.onValueChanged.AddListener(SetSFX);
        BGMSlider.onValueChanged.AddListener(SetBGM);
        
        bgm.Play();
    }

    void SetSFX(float volume)
    {
        Debug.Log("SetSFX called: " + volume);
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFX", volume);
    }

    void SetBGM(float volume)
    {
        Debug.Log("SetBGM called: " + volume);
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
