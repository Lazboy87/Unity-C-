using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class DooropenL : MonoBehaviour
{
    public GameObject Door;
    public float Xposition;
    public float Yposition;
    public float Zposition;
    bool toggle;

    
  
   
   

    
   
    public bool unlocked;
    bool playerinside;

    // Start is called before the first frame update
    void Start()
    {
     
        playerinside = false;
    }
        
   

    // Update is called once per frame
    void Update()
    {
        



        if (playerinside == true && unlocked == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;

                if (toggle)
                {

                    Door.transform.Translate(Xposition,Yposition,Zposition*Time.timeScale);




                }
                 
                if (!toggle)
                {

                    Door.transform.Translate(-Xposition, -Yposition, -Zposition);

                }

               


                
               

            }
                
              
            }
            
        }

   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinside = true;

        } }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinside = false;

        }
    }
    


    void OnGUI()
        {
            if (unlocked == true && playerinside == true)
            {
                GUI.Label(new Rect(900, 500, 250, 250), "To open/close door press E");

            }
               if(playerinside == true && unlocked == false)
            {
                 GUI.Label(new Rect(900, 500, 250, 250), "door is locked");
            }
        }

   

}
    

