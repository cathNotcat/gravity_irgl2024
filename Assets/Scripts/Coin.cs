using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Obstacles.upSpeed += 0.01f;

            AddCoin.addCoin++;

            NormalCoin.addCoin += 20;

            Destroy(gameObject);
        }
    }
}
