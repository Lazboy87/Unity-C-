using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject pause;
    public GameObject died;
    public GameObject player;
    public static float currentHealth = 100f;
    public float internalHealth;
    public SimpleHealthBar healthBar;
    void Update()
    {
        if(currentHealth <= 0f)
        {
            
            
            pause.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        


        internalHealth = currentHealth;
        healthBar.UpdateBar(currentHealth, 100f);
       // healthBar.UpdateColor();
       // healthBar.UpdateTextColor(Color.white);
    }

}
