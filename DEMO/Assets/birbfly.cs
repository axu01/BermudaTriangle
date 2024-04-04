using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbfly : MonoBehaviour
{
    // Start is called before the first frame update
    public float movSpeed = 10.4f;
    float speedX, speedY;
    Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        rb.velocity = new Vector2(speedX, speedY);

    }
}
