using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPrefab;

    public float spawnInterval = 1.0f;
    public float objNum;
    private float spawnTimer;

    public float spawnFuzzy = 0.5f;

    public int livingSpawns;// { get; private set; }

    void Start()
    {
        spawnTimer = spawnInterval;
    }

	void Update ()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer < 0)
        {
            spawnTimer = spawnInterval + Random.Range(-spawnFuzzy, spawnFuzzy);
            GameObject baby = Instantiate(spawnPrefab);
            baby.AddComponent <SpawnTracker>().origin = this;
            Instantiate(spawnPrefab);
        }
	}
}
