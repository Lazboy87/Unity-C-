using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Frontdooropen : MonoBehaviour
{
    public GameObject lever1;
    public GameObject lever2;
    public GameObject lever3;
    public GameObject lever4;

    public GameObject DoorL;
    public GameObject DoorR;
    public GameObject end;
    public GameObject endlight;
    public GameObject meshdisable;



    bool allactive;





    // Start is called before the first frame update
    void Start()
    {
        allactive = false;
        meshdisable.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (lever1.transform.eulerAngles.z == (357) && lever2.transform.eulerAngles.z == (357)
            && lever3.transform.eulerAngles.z == (357) && lever4.transform.eulerAngles.z == (357))
        {
            DoorL.SetActive(false);
            DoorR.SetActive(false);
            allactive = true;
            end.SetActive(true);
            endlight.SetActive(true);
            meshdisable.SetActive(false);


        }
        else
        {
            DoorL.SetActive(true);
            DoorR.SetActive(true);
            DoorL.transform.Rotate(0, 0, 0);
            DoorR.transform.Rotate(0, 0, 0);
            allactive = false;
            end.SetActive(false);
            endlight.SetActive(false);
            meshdisable.SetActive(true);
        }
    }
    void OnGUI()
    {

        if (allactive == true)
        {

            GUI.Label(new Rect(900, 500, 250, 250), "The Front door is open get outa here!! ");
        }
    }


}
