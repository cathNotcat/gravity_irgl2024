using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject box1;
    [SerializeField] GameObject box2;
    [SerializeField] GameObject box3;
    [SerializeField] GameObject trap1;
    [SerializeField] GameObject trap2;
    float box2Chance = 0.9f;
    float box3Chance = 0.8f;
    float box1Chance = 0.7f;

    float fireTimer = 0;
    float sawTimer = 0;
    float timer = 0;

    void Start()
    {
        Instantiate(box1, new Vector3(0, -5.3f), Quaternion.identity);
    }
    void Update()
    {
        timer += Time.deltaTime;
        fireTimer += Time.deltaTime;
        sawTimer += Time.deltaTime;

        if(timer > 1.5f)
        {
            GroundSpawn();
            timer = 0;
        }

        if(fireTimer > 3)
        {
            FireSpawn();
            fireTimer = 0;
        }

        if(sawTimer > 5)
        {
            SawSpawn();
            sawTimer = 0;
        }
    }

    void GroundSpawn()
    {
        GameObject obsToSpawn = box1;
        float random = Random.Range(0f, 1f);

        if (random < box2Chance)
        {
            obsToSpawn = box2;
        }

        else if (random < box3Chance)
        {
            obsToSpawn = box3;
        }
        
        else if (random < box1Chance)
        {
            obsToSpawn = box1;
        }

        Instantiate(obsToSpawn, new Vector3(Random.Range(-8.5f, 8.5f), -5.3f), Quaternion.identity);
    }

    void FireSpawn()
    {
        if(Score.score > 5)
        {
            Instantiate(trap1, new Vector3(Random.Range(-8.5f, 8.5f), -5.3f), Quaternion.identity);
        }
    }

    void SawSpawn()
    {
        if(Score.score > 8)
        {
            Instantiate(trap2, new Vector3(Random.Range(-8.5f, 8.5f), -5.3f), Quaternion.identity);
        }
    }
}
