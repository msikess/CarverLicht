using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimRigShift : MonoBehaviour {


    // Use this for initialization
    void Start()
    {

    }
    public float amplitudeX = 10.0f;
    public float frequencyX = .05f;
    float rotationY = 0.0f;
    float rotationX = 0.0f;

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(rotationX, rotationY, amplitudeX * Mathf.Sin(frequencyX * Time.frameCount));

    }
}