using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlannets : MonoBehaviour
{
    public GameObject[] animalPrefebs;
    //public float SpawnRangeX = 15;
    public float spawnPosZ = 30;
    public float SpawnRangeY;
    public float startdelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomplanets", startdelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomplanets()
    {
        int animalIndex = Random.Range(0, animalPrefebs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-850, 1200), SpawnRangeY, spawnPosZ);
        Instantiate(animalPrefebs[animalIndex], spawnpos, animalPrefebs[animalIndex].transform.rotation);

    }
}
