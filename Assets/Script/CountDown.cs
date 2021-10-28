using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountDown : MonoBehaviour

{
    public Text timeText;
    private float timer = 15;
    private bool isRed = false;
    public Material blue;
    public Material red;
    private RandomMovement randomMovement;
    private ChasePlayer chasePlayer;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountdownTimer();
    }

    public void CountdownTimer()
    {
        if (isRed == true)
        {
            timer -= Time.deltaTime / 2;
            timeText.text = "Time: " + Mathf.Round(timer);
        }
        if (timer <= 0)
        {

            gameOver.SetActive(true);
            timer = 0;
            // score += score;
            Debug.Log("GAMEOVER!");
            /// restartButton.gameObject.SetActive(true);
            // RestartGame();
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided");
            isRed = !isRed;
            if (isRed)
            {
                collision.gameObject.GetComponent<Renderer>().material = blue;
                gameObject.GetComponent<Renderer>().material = red;

                collision.gameObject.GetComponent<RandomMovement>().enabled = true;
                collision.gameObject.GetComponent<ChasePlayer>().enabled = false;

                timer = 10;

            }

            else
            {
                gameObject.GetComponent<Renderer>().material = blue;
                collision.gameObject.GetComponent<Renderer>().material = red;
                collision.gameObject.GetComponent<ChasePlayer>().enabled = true;
                collision.gameObject.GetComponent<RandomMovement>().enabled = false;


            }


        }
    }

    /*  if (timer <= 0 || score == 10)
      {

          gameOver.gameObject.SetActive(true);
          timer = 0;
          score += score;
          Debug.Log("GAMEOVER!");
          restartButton.gameObject.SetActive(true);
          RestartGame();
      }
  }
}
    */
}
