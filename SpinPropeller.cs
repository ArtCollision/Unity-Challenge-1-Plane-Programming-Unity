using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float propellerspeed = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spins propeller based on the variable "propellerspeed"
        transform.Rotate (Vector3.forward * Time.deltaTime * propellerspeed);
    }
}
