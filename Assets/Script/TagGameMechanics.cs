using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagGameMechanics : MonoBehaviour
{
    public Material redColor;
    public Material blueColor;
    bool blue = false ;
    bool red = false;
    int counter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // if (blue == true)
        //    gameObject.GetComponent<Renderer>().material.color = Color.blue;

      //  if (red == true)
         //   gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnCollisionEnter(Collision collision)
    {
        red = !red;
        if (red)
        {
            collision.gameObject.GetComponent<Renderer>().material = blueColor;
            gameObject.GetComponent<Renderer>().material = redColor;

        }
        else
        {
            gameObject.GetComponent<Renderer>().material = blueColor;
            collision.gameObject.GetComponent<Renderer>().material = redColor;
        }
    }
}
