using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    [SerializeField]
    private float cooldown = 1f;

    [SerializeField]
    private float startTime = 0f;

    [SerializeField]
    private float timer = 0f;

    [SerializeField]
    private GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        timer = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < cooldown)
        {
            timer += Time.deltaTime;
        } else if (timer >= cooldown)
        {
            timer = 0f;
            Spawn();
        }

    }

    void Spawn()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
