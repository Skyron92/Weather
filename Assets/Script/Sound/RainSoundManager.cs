using UnityEngine;

public class RainSoundManager : SoundManager
{
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0;
    }
    private void Update()
    {
        UpVolume(SkyState.isRainy);
        DownVolume(SkyState.isSunny || SkyState.isSnowy || SkyState.isWindy);
    }
}