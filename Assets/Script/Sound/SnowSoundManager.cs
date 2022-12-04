using UnityEngine;

public class SnowSoundManager : SoundManager
{
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0;
    }

    private void Update()
    {
        UpVolume(SkyState.isSnowy);
        DownVolume(SkyState.isRainy || SkyState.isSunny || SkyState.isWindy);
    }

    
}