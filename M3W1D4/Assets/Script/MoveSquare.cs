using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour 
{
    public float speed = 5f;
    public float maxDistance = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        float distance = Vector2.Distance(transform.position, startPosition);
        if (distance > maxDistance)
        {
            rb.position = startPosition;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement * speed * Time.fixedDeltaTime);
    }
}
