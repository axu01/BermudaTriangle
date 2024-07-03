using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class IdleMovement : MonoBehaviour
{

    // Start is called before the first frame update
    //public GameObject birb;
    public float movSpeed = 10.4f;
    float speedX, speedY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(100f, 0f) * Time.deltaTime);
        //Vector3 pos = transform.position;
        //speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        //speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        //rb.velocity = new Vector2(speedX, speedY);

    }
}
