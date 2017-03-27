using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawnerTrack : MonoBehaviour
{
    public ObsticleSpawner origin;

    private void OnDestroy()
    {
        origin.livingSpawns--;
    }
}