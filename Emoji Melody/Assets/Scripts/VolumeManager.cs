using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private AudioSource audioSource;
    public static float volume = 0.5f;

    private void Start()
    {
        Debug.Log(volume);
        volumeSlider.value = volume;
        audioSource.volume = volume;
    }

    private void Update()
    {
        audioSource.volume = volumeSlider.value;
        volume = volumeSlider.value;
    }
}
