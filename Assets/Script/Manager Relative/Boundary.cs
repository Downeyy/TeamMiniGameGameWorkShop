using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private float zMax = 6f;
    private float zMin =-4.3f;
    private float xMin = -10f;
    private float xMax = 10f;


    private void Update()
    {
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }
        if (transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }
    }


}
