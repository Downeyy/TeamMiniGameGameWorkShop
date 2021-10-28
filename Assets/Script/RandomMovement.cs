using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float RanX;
    public float RanZ;
    private Vector3 destination = Vector3.zero;
    public bool isRed;
    public Material blue;
    public Material red;
   
    // Start is called before the first frame update
    void Start()


    {



        InvokeRepeating("SetRandomDirection", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(destination * speed * Time.deltaTime);
    }

    void SetRandomDirection()
    {
        RanX = Random.Range(-1f, 1f);
        RanZ = Random.Range(-1f, 1f);
        destination = new Vector3(RanX, 0f, RanZ);
    }


  /*  void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (isRed)
            {
                gameObject.GetComponent<Renderer>().material = blue;
                collision.gameObject.GetComponent<Renderer>().material = red;
                isRed = false;
                GetComponent<RandomMovement>().enabled = true;
                GetComponent<ChasePlayer>().enabled = false;

            }
            else
            {
                gameObject.GetComponent<Renderer>().material = red;
                collision.gameObject.GetComponent<Renderer>().material = blue;
                GetComponent<ChasePlayer>().enabled = true;
                GetComponent<RandomMovement>().enabled = false;

                isRed = true;
            }


        }
    }
}


        void OnCollisionEnter(Collision collision)
        {


          //  if (collision.transform.name == "Enemy")
           {
              Score.score -= 1;

           } */

       }
    
