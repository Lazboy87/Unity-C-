using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerzombie : MonoBehaviour
{
    public GameObject zomb;
    bool playerinside;
    // Start is called before the first frame update
    void Start()
    {
        playerinside = false;
        zomb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            zomb.SetActive(true);
        }

        else { }
        
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
            playerinside = false;

        }
    }






        }

