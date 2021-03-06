﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMulti : MonoBehaviour
{

    //array für Gegner
    public GameObject[] enemies;

    //Area wo sie spawnen können
    public Vector3 spawnValues;

    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnemy;


    
    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

    }


    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds (startWait);
        while (!stop) 
        {
            randEnemy = Random.Range(0, 3);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
