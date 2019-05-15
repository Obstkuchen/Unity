using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

 

    private void Start()
    {
        spawnSomething();
    }

   

    void spawnSomething()


    {

        

        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform) as GameObject;
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[1].transform) as GameObject;
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[2].transform) as GameObject;






    }













}

