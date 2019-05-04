using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float jump;
    private Rigidbody2D rb;
    private bool jumped = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = Vector2.left * speed;
        else if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = Vector2.right * speed;
        else
            rb.velocity = new Vector2(0f, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumped == false)
            rb.AddForce(Vector2.up * jump);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            jumped = false;
    }
}
