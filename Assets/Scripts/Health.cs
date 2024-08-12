using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   public Text healthText; 
   public static int health = 100;
   Color color;
    
    void Start()
    {
        health = 100;
        color = new Color(0,0,0,100);
    }
    void Update()
    {
        healthText.text = "HEALTH : " + health.ToString();

        if(Traps.hurt == true)
        {
            color = new Color(100,0,0,100);
            healthText.color = color;
        }
        else
        {
            color = new Color(0,0,0,100);
            healthText.color = color;
        }
    }
}
