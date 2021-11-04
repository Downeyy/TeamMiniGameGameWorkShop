using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;

    public bool ifPlayerOne;
    public bool ifPlayerTwo;

    private void Update()
    {
        MovePlayerOne();
        MovePlayerTwo();
    }

    void MovePlayerOne()
    {
        if (Input.GetKey(KeyCode.W) && (ifPlayerOne))
        {
            //move up
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.S) && (ifPlayerOne))
        {
            //move down 
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.A) && (ifPlayerOne))
        {
            //move left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D) && (ifPlayerOne))
        {
            //move right    
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    void MovePlayerTwo()
    {
        if (Input.GetKey(KeyCode.UpArrow) && (ifPlayerTwo))
        {
            //move up
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.DownArrow) && (ifPlayerTwo))
        {
            //move down 
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow) && (ifPlayerTwo))
        {
            //move left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && (ifPlayerTwo))
        {
            //move right    
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
    
}
