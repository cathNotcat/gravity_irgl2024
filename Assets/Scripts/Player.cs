using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public static bool alive;

    //Showed on Inspector but cannot be accessed through other scripts
    [SerializeField] Rigidbody2D rb;
    [SerializeField] BoxCollider2D bc;
    [SerializeField] private LayerMask groundLM;
    [SerializeField] float jumpVel = 8f;

    //Not showed on Inspector and cannot be accessed through scripts
    public float increaseSpeed = 0.1f;
    public float speed = 2;

    Vector2 direction;

    void Start()
    {
        speed = 8;
    }   
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.5f, 8.5f), Mathf.Clamp(transform.position.y, -6f, 4.7f), transform.position.z);

        Die();

        Movement();

        if(Input.GetKey(KeyCode.Escape))
        {
            gameManager.Pause();
        }
    }
    void Movement()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(direction.x,0,0) * speed * Time.deltaTime;

        if(direction.x < 0)
        {
            transform.localScale = new Vector2(-2, 2);
        }
        else if(direction.x > 0)
        {
            transform.localScale = new Vector2(2, 2);
        }
        if(IsGrounded() && Input.GetKey(KeyCode.Space))
        {
        
            rb.velocity = Vector2.up * jumpVel;
        }
    }
    bool IsGrounded()
    {
        RaycastHit2D rc = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0, Vector2.down, .1f, groundLM);
        
        return rc.collider != null;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name != "Fire")
        {
            Traps.hurt = false;
        }
    }
    void Die()
    {
        if(Health.health < 1 ||transform.position.y < -5)
        {
            gameManager.GameOver();
        }
    }
}
