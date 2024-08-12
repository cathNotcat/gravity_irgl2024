using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] GameObject obs;
    Rigidbody2D rb;
    public static float upSpeed;
    void Start()
    {
        upSpeed = 1.5f;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 force = new Vector2(0, 1);
        obs.transform.position += transform.up * Time.deltaTime * upSpeed;
        rb.AddForce(force, ForceMode2D.Force);
        Destroy(gameObject, 10);
    }
}
