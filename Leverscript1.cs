using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class Leverscript1 : MonoBehaviour
{
    public GameObject Doorlightred;
    public GameObject Doorlightgreen;

    public GameObject Leverhandle;

    public GameObject Leverlightred;
    public GameObject Leverlightgreen;

    public float Xrot;
    public float Yrot;
    public float Zrot;

    
    bool Toggle;
    bool playerinside;
    





    // Start is called before the first frame update
    void Start()
    {
        playerinside = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerinside == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Toggle = !Toggle;

                if (Toggle)
                {
                    Leverhandle.transform.Rotate(-Xrot, -Yrot, -Zrot);
                    Leverlightred.SetActive(false);
                    Leverlightgreen.SetActive(true);
                    Doorlightred.SetActive(false);
                    Doorlightgreen.SetActive(true);
                 


                }

                if (!Toggle)
                {
                    Leverhandle.transform.Rotate(Xrot, Yrot, Zrot);
                    Leverlightred.SetActive(true);
                    Leverlightgreen.SetActive(false);
                    Doorlightred.SetActive(true);
                    Doorlightgreen.SetActive(false);
                    
                }


            }
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
            playerinside = false;

        }
    }


    void OnGUI()
    {

        if (playerinside == true)
        {

            GUI.Label(new Rect(900, 500, 250, 250), "Press E to Pull Lever ");
        }
    }
}
