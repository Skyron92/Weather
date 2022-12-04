using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSoundManager : SoundManager
{
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        UpVolume(SkyState.isSunny);
        DownVolume(SkyState.isRainy || SkyState.isSnowy || SkyState.isWindy);
    }
}