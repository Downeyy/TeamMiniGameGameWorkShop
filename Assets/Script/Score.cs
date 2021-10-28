using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text timeText;
    private float timer = 15;
    private PlayerController1 playerController;
    public static int score = 0;
    public TextMeshProUGUI gameOver;
    public Text scoreText;
    private Button restartButton;
    public bool isGameGoing;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score.ToString();
        
    }



   

         public  void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
