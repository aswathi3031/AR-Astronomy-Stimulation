using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform world;
    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        world = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new rotation
        Quaternion newRotation = Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0) * world.rotation;
        
        // Apply the new rotation
        world.rotation = newRotation;
    }
}
