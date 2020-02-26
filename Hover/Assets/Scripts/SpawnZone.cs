using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    public Vector3 Spawnpoint
    {
        get
        {
            return Random.insideUnitSphere * 10f;
        }
    }

}

