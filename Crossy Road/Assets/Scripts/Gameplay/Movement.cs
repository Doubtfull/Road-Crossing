using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos = Vector3.up + transform.position;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            pos = Vector3.down + transform.position;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pos = Vector3.right + transform.position;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = Vector3.left + transform.position;
        }

        transform.position = pos;
    }
}
