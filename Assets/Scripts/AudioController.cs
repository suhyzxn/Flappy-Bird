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
        GameObject[] controllers = GameObject.FindGameObjectsWithTag("Music");

        if (controllers.Length > 1)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(this);

        SFXSlider.onValueChanged.AddListener(SetSFX);
        BGMSlider.onValueChanged.AddListener(SetBGM);
    }

    void SetSFX(float volume)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }

    void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }
}
