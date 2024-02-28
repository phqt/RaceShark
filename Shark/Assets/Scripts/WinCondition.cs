using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject winScreen;
    public GameObject winCamera;
    public GameObject loseGround;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            //thePlayer.GetComponent<CarControl>().enabled = false;
            //thePlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            loseGround.GetComponent<BoxCollider>().isTrigger = false;
            winCamera.SetActive(true);
        }
    }
}
