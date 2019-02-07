using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outofhouse : MonoBehaviour
{
    public GameObject player;
    bool playerinside;
    public GameObject house;
  
    

    private Transform PlayerTransform;

    // Start is called before the first frame update
    void Start()
    {
        house.SetActive(true);
        playerinside = false;
       

}

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            player.transform.Translate(0, 0, 20);
            house.SetActive(false);
            
           
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