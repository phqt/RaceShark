using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject endingScreen;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            endingScreen.SetActive(true);
            thePlayer.GetComponent<CarControl>().enabled = false;
            thePlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

}
