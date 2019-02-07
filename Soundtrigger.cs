using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundtrigger : MonoBehaviour
{
    public GameObject soundbox;
    bool playerinside;
    bool playerexit;


    // Start is called before the first frame update
    void Start()
    {
        playerinside = false;
    }

    // Update is called once per frame
    void Update()
    {if (playerinside == true)
        {
            soundbox.SetActive(true);
        }
        if (playerexit==true){
            
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinside = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerexit = true;
            

        }
    }

}
