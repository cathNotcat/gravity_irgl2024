using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningPlayerMenu : MonoBehaviour
{
    float speed = 1.5f;
    float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 10)
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * speed;
            transform.localScale = new Vector3(-2.5f, 2.5f, 0);
            if(timer > 20)
            {
                timer = 0;
            }
        }
        else
        {
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;
            transform.localScale = new Vector3(2.5f, 2.5f, 0);
        }
    }
}
