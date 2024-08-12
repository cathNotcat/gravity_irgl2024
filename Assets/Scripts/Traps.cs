using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public static bool hurt = false;
    Traps trap;
    Rigidbody2D rb;
    public static bool spawn;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trap = gameObject.GetComponent<Traps>();
    }
    void Update()
    {
        GoUp();
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            hurt = true;
            Health.health -= 10;
        }
    }

    void GoUp()
    {
        Vector2 force = new Vector2(0, 1);
        trap.transform.position += transform.up * Time.deltaTime * 1.5f;
        rb.AddForce(force, ForceMode2D.Force);
        Destroy(gameObject, 10);
    }
}
