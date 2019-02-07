using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createhouse : MonoBehaviour
{
    public GameObject house;
    bool playerinside;
    public GameObject meshhouse;
    
    // Start is called before the first frame update
    void Start()
    {
        playerinside = false;
        house.SetActive(false);
        meshhouse.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            house.SetActive(true);
            meshhouse.SetActive(true);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinside = true;

        }

    }
}
