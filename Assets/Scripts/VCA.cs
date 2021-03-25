using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCA : MonoBehaviour
{
    FMOD.Studio.EventInstance instance;
    FMOD.Studio.VCA vca;

    [FMODUnity.EventRef]
    public string fmodEvent;

    [SerializeField]
    [Range(-80f, 10f)]
    private float vcaVolume;

    private float volume;

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();

        vca = FMODUnity.RuntimeManager.GetVCA("vca:/MusicVCA");
    }
    void Update()
    {
        volume = Mathf.Pow(10.0f, vcaVolume / 20f);
        vca.setVolume(volume);
    }
}
