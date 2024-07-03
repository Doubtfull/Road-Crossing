using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    GameObject GameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            GameOverMenu.SetActive(true);
        }
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
