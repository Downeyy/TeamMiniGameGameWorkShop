using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public float zMax =-10f;
    public float zMin = -18f;
    public float xMin = -2f;
    public float xMax = 11f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(gameObject)
        {
            if (transform.position.x >= xMax)
            {
                transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
            }

            else if (transform.position.x <= xMin)
            {
                transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
            }


        }

        if (transform.position.z >= zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        else if (transform.position.z <= zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
    }
}
