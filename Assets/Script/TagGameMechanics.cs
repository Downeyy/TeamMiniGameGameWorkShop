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
     PlayerController1 playerController1;
     Player2Controller player2Controller;
    // Start is called before the first frame update
    void Start()
    {
        // Calling movementSpeed variable from PlayerController Script 
      GameObject Player1 = GameObject.Find("Player1");
     playerController1 = Player1.GetComponent<PlayerController1>();
      playerController1.movementSpeed = 6.0f;
      GameObject Player2 = GameObject.Find("Player2");
     player2Controller = Player2.GetComponent<Player2Controller>();
      player2Controller.movementSpeed = 7.0f;
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
            playerController1.movementSpeed = 6;
            player2Controller.movementSpeed = 7;

        }
        else
        {
            gameObject.GetComponent<Renderer>().material = blueColor;
            collision.gameObject.GetComponent<Renderer>().material = redColor;
            // On collision Player 1 movement speed is 7 and player 2's is 6
            playerController1.movementSpeed = 7;
              player2Controller.movementSpeed = 6;
        }
    }
}
