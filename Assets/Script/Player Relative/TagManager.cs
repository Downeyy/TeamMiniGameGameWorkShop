using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    public bool canBeTagged = true;

    public bool isTagged = false; //blue player is always player 1

    public TimerManager tManager;

    public GameObject Player2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2") && canBeTagged)
        {
                             
            if(isTagged == true)
            {
                isTagged = false;
                //set blue timer for win
                tManager.RedToWIn();
                
              //  Debug.Log("Blue To Win");
                // AJ added a function to change icon of player
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.transform.GetChild(1).gameObject.SetActive(false);
                Player2.transform.GetChild(0).gameObject.SetActive(true);
                Player2.transform.GetChild(1).gameObject.SetActive(false);
                canBeTagged = false;
            }
            else if(isTagged == false)              
            {
                isTagged = true;
                tManager.BlueToWIn();
                //Debug.Log("Red To Win");
                // AJ added a function to change icon of player
               Player2.transform.GetChild(1).gameObject.SetActive(true);
               Player2.transform.GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
                gameObject.transform.GetChild(0).gameObject.SetActive(false);
                //set red timer for win
                canBeTagged = false;
            }
            StartCoroutine(NoTagBacks(1));
        }
    }

    public IEnumerator NoTagBacks(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        canBeTagged = true;
    }
}
