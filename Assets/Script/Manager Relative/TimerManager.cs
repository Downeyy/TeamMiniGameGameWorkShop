using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerManager : MonoBehaviour
{
    public Text timer1;
    public Text timer2;

    public float timer1Val;
    public float timer2Val;

    private int timerScale1; //value for stoping Coroutine
    private int timerScale2;

    public TagManager tManager;
    private Text gameOverMessenger;

    //private Text
    public bool winCondition = false;
    private void Start()
    {

        timer1.text = "Collide To Start!";

        //  StartCoroutine(StartTimerOne(1));
    }
    private bool gameOver;
    public bool player1;
    private void Update()
    {
        if (player1 && winCondition) 
        {
            // Counter
            tempCount -= Time.deltaTime;
            if (tempCount < 0.0f)
            {
                //Update Text
                gameOverMessenger = gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();
                timer1.text = ("");
                gameOverMessenger.text = "Player One Wins!";
                gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            //Update Timer
            else
            {
                timer1.text = ("Time Until P1 Wins " + Mathf.RoundToInt(tempCount).ToString());
            }

        }
        //Player 2
        else
        {
            if (winCondition)
            {
                tempCount -= Time.deltaTime;
                if (tempCount < 0.0f)
                {
                    gameOverMessenger = gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();
                    timer1.text = ("");
                    gameOverMessenger.text = "Player Two Wins!";
                    gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(true);
                    Time.timeScale = 0;
                }
                else
                {
                    timer1.text = ("Time Until P2 Wins " + Mathf.RoundToInt(tempCount).ToString());
                }
            }
        }
     /*   // We should make a single timer toggling text if player gets collided w/ instead of two timers 
        //timer 1
        timer1.text = ("Time Until P1 Win: " + timer1Val);
        //timer 2
        timer2.text = ("Time Until P2 Win: " + timer2Val);
        
        if (timer1Val <= 0)
        {
            gameOver = true;
          
           gameOverMessenger = gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.GetComponent<Text>() ;
            gameOverMessenger.text = "Player One Wins!";
           gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(true);
          //  Debug.Log("Player 1 wins");
        }
        if (timer2Val <= 0)
        {
            gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(true);
            gameOver = true;
          //  Debug.Log("Player 2 wins");
        }
     */
    }
    /*
    public IEnumerator StartTimerOne(int seconds)
    {
        //
        yield return new WaitForSeconds(seconds);
        
        if (tManager.isTagged == false)
        {
            timer1Val = timer1Val - 1;
            StartCoroutine(StartTimerOne(1));

        }
       
        
        //add 1 to timer
    }
    public IEnumerator StartTimerTwo(int seconds)
    {
        //
        yield return new WaitForSeconds(seconds);
        
        if(tManager.isTagged == true)
        {
            timer2Val = timer2Val - 1;
            StartCoroutine(StartTimerTwo(1));
        }

        //add 1 to timer
    }
    */
    public float countDown;
    public float tempCount;
    public void BlueToWIn()
    {
        tempCount = countDown;
        player1 = true;
        winCondition = true;
        //timer1Val = 10;
        //timer2Val = 10;
        //StartCoroutine(StartTimerTwo(1));


    }

    public void RedToWIn()
    {
         tempCount = countDown;
        player1 = false;
        winCondition = true;

        //timer1Val = 10;
        //timer2Val = 10;
        //StartCoroutine(StartTimerOne(1));

    }
   
   
    
   
}
    