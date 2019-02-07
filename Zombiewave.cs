using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiewave : MonoBehaviour
{
    public GameObject wave;
    bool playerinside;
    // Start is called before the first frame update
    void Start()
    {
        wave.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            wave.SetActive(true);
            


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
