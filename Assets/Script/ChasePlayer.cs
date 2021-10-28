using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public Rigidbody enemyRb;
    public GameObject player;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(lookDirection * speed);
        transform.Translate(lookDirection * speed * Time.deltaTime);
    }

  

    void ChangeEnemyControl()
    {
        
    }
}

