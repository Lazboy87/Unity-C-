using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Pickup : MonoBehaviour
{

    public GameObject item;
    public GameObject itemimage;
    public GameObject itemget;
    

    

    bool playerinside;

    
    

    

    // Start is called before the first frame update
    void Start()
    {
        
        playerinside = false;
        itemimage.SetActive(false);
        itemget.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(item);
                itemimage.SetActive(true);
                
                itemget.SetActive(true);
            }

        }
        else { }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerinside = false;

        }






    }




    void OnTriggerEnter(Collider other)
    { if (other.CompareTag("Player"))
        {
            playerinside = true;

        }

        
            



        }
  void OnGUI(){
       
        if (playerinside == true)
        {

            GUI.Label(new Rect(900, 500,250, 250), "Press E to pick up "+ (item.name) );
        }

        
           
           

        
        
        

    }
}



    


        
   
            

        
