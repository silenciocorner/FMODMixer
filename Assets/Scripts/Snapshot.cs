using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapshot : MonoBehaviour
{
    FMOD.Studio.EventInstance snapshot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            snapshot = FMODUnity.RuntimeManager.CreateInstance("snapshot:/FilterMusic");
            snapshot.start();
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            snapshot.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
            snapshot.release();
        }
    }
}
