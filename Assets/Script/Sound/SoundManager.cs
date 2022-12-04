using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource _audioSource;
    public void DownVolume(bool state) {
        if (state) {
            _audioSource.volume -= Time.deltaTime;
        }
    }

    public void UpVolume(bool state) {
        if (state)
        {
            _audioSource.volume += Time.deltaTime;
        }
    }
}