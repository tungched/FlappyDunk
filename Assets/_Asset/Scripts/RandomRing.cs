using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRing : MonoBehaviour
{
    private GameObject ringSpawn;
    [SerializeField] private List<GameObject> ListRingRandom;
    public float spawnTime = 1f;
    public float spawnDelay = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = spawnTime;
    }
    



    // Update is called once per frame
    void Update()
    {
        if (spawnDelay >= spawnTime)
        {
            SpawnTime();
            spawnDelay = 0;
        }
        spawnDelay += Time.deltaTime;
    }

    public void SpawnTime()
    {
        int random = Random.Range(0, ListRingRandom.Count);
        ringSpawn = Instantiate(ListRingRandom[random], new Vector3(37,Random.Range(2,-2), 0), Quaternion.identity);
    }
}
