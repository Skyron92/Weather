using UnityEngine;

public class WindSoundManager : SoundManager
{
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0;
    }

    private void Update()
    {
        UpVolume(SkyState.isWindy);
        DownVolume(SkyState.isRainy || SkyState.isSnowy || SkyState.isSunny);
    }
}