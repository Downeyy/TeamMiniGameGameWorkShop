using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player2Controller : MonoBehaviour
{

    public PlayerController1 playerController1;
    public float movementSpeed = 10.0f;
    public float horizontalInput;
    public float verticalInput;
    public Text timerText2;
    public float timer2 = 5;
    public bool timerActive;

    private int counter;
    private RandomMovement randomMovement;
    private ChasePlayer chasePlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    //float horizontalInput = Input.GetAxis("Horizontal");
    //float veticalInput = Input.GetAxis("Vertical");
    {

        Left();
        Right();
        Up();
        Down();
        CountDown();
    }


    void Down()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back.normalized * Time.deltaTime * movementSpeed);
        }
    }

    void Up()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward.normalized * Time.deltaTime * movementSpeed);
        }
    }

    void Left()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left.normalized * Time.deltaTime * movementSpeed);
        }
    }

    void Right()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right.normalized * Time.deltaTime * movementSpeed);
        }
    }
    void CountDown()
    {
        if (!timerActive)
        {
            return;
        }
        if (timer2 > 0)
        {
            timerText2.text = "Time: " + Mathf.Round(timer2);
            timer2 -= Time.deltaTime;

        }

        else
        {
            Debug.Log("Player2 wins, Player 1 loses!!");
        }
    }
}




