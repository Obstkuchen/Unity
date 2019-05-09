using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Object hover and spinning
public class HoverSpin : MonoBehaviour
{
    //inputs
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

    // Position
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    //initialization
    void Start()
    {
        //Store the starting position and rotation of the Object
        posOffset = transform.position;
    }

    //Update once per Frame
    void Update()
    {

        //Spin Object
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        //Hover up/down with Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;

    }
}