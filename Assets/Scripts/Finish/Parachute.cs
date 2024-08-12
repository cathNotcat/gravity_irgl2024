using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    [SerializeField] GameObject parachute;
    
    [SerializeField] GameObject charIdle;
    [SerializeField] GameObject YouWonCanvas;
    GameManager gameManager;
    float speed = 1;

    void Start()
    {
        YouWonCanvas.SetActive(false);
        charIdle.SetActive(false);
    }
    void Update()
    {
        if(parachute.transform.position.y > -4.23)
        {   
            parachute.transform.position += new Vector3(0, -1, 0) * Time.deltaTime * speed;
        }
        else
        {
            Destroy(parachute);

            charIdle.SetActive(true);
            YouWonCanvas.SetActive(true);
        }
    }
}
