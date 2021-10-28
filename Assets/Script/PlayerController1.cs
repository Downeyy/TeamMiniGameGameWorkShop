using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
{
    //movement speed in units per second
    public Player2Controller Player2Controller;
    public float movementSpeed = 10.0f;
    public float horizontalInput;
    public float verticalInput;

    private int counter;
    private RandomMovement randomMovement;
    private ChasePlayer chasePlayer;
    public float timer = 20;
    public Text timeText;
    public bool timerActive;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    //float horizontalInput = Input.GetAxis("Horizontal");
    //float veticalInput = Input.GetAxis("Vertical");
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);


        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * movementSpeed);
        CountDown();
    }

    void CountDown()
    {
        if (!timerActive)
        {
            return;
        }
        if (timer > 0)
        {
            timeText.text = "Time: " + Mathf.Round(timer);
            timer -= Time.deltaTime;

        }

        else
        {
            Debug.Log("Player1 wins, Player 2 loses!!");
        }
    }
}



