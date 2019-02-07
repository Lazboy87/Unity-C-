using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemactivate : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject sights;
    public GameObject itemdestroyed1;
    public GameObject itemdestroyed2;




    bool toggle;

    // Start is called before the first frame update
    void Start()
    {
        
        item1.SetActive(false);
        item2.SetActive(false);
        sights.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (itemdestroyed1==null) { 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            toggle = !toggle;

            if (toggle)
            {
                item1.SetActive(true);
            }
            if (!toggle)
            {
                item1.SetActive(false);
            }
            }
        }
        if (itemdestroyed2 == null) { 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            toggle = !toggle;

            if (toggle)
                item2.SetActive(true);
            sights.SetActive(true);


        }
        if (!toggle) { 
            item2.SetActive(false);
            sights.SetActive(false);

        }
        }
    }
    
        
    
}
