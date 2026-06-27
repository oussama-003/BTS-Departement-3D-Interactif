using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour

{

    public GameObject interactive;
    public GameObject interactive1;
   // public GameObject interactive2;



    void Start()

    {

        interactive.SetActive(false);
        interactive1.SetActive(false);
      //  interactive2.SetActive(false);

    }



    void OnTriggerEnter(Collider player)

    {

        if (player.gameObject.tag == "Player")

        {

            interactive.SetActive(true);
            interactive1.SetActive(true);
           // interactive2.SetActive(true);

        }

    }



    void OnTriggerExit(Collider player)

    {

        if (player.gameObject.tag == "Player")

        {

            interactive.SetActive(false);
            interactive1.SetActive(false);
           // interactive2.SetActive(false);

        }

    }

}