using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{ 
    public GameObject spawnPrefab;

    public float spawnInterval = 1.0f;  
    private float spawnTimer;  

    public float spawnFuzzy = 0.5f;

    public int livingSpawns;
    public int maxLivingSpawns = 5;

    void Start()
    {
        spawnTimer = spawnInterval;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0 && livingSpawns < maxLivingSpawns)
        {
            spawnTimer = spawnInterval + Random.Range(-spawnFuzzy, spawnFuzzy);
            GameObject baby = Instantiate(spawnPrefab, gameObject.transform);
            baby.AddComponent<ObsticleSpawnerTrack>().origin = this;
            livingSpawns++;
        }
    }
}