using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animalPrefebs;
    public float SpawnRangeX = 15;
    public float spawnPosZ = 30;
    public float startdelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", startdelay, spawnInterval);  
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRandomEnemies()
    {
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-18, 38.3f), 0, spawnPosZ);
        Instantiate(animalPrefebs[animalIndex], spawnpos, animalPrefebs[animalIndex].transform.rotation);

    }
}
