using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;


    private Vector3 movement;
    public float speed;
    public bool darkMode;


    void Start()
    {
        darkMode = false;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

       // if (Input.getAxisRaw) {
        //}

        if (darkMode) {
            this.GetComponent<SpriteRenderer>().color = Color.black;
        }

        if (!darkMode) {
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }

        // movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {

        // movement
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
}
