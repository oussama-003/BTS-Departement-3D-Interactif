using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightonoff8 : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text

    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject lightorobj0;
    public GameObject lightorobj1;
    public GameObject lightorobj2;
    public GameObject lightorobj3;
    public GameObject lightorobj4;
    public GameObject lightorobj5;
    public GameObject lightorobj6;
    public GameObject lightorobj7;
    public GameObject lightorobj8;
    public GameObject lightorobj9;

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E))           //if in zone and press F key
        {
            lightorobj0.SetActive(!lightorobj0.activeSelf);
            lightorobj1.SetActive(!lightorobj1.activeSelf);
            lightorobj2.SetActive(!lightorobj2.activeSelf);
            lightorobj3.SetActive(!lightorobj3.activeSelf);
            lightorobj4.SetActive(!lightorobj4.activeSelf);
            lightorobj5.SetActive(!lightorobj5.activeSelf);
            lightorobj6.SetActive(!lightorobj6.activeSelf);
            lightorobj7.SetActive(!lightorobj7.activeSelf);
            lightorobj8.SetActive(!lightorobj8.activeSelf);
            lightorobj9.SetActive(!lightorobj9.activeSelf);
            //gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("switch");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}
