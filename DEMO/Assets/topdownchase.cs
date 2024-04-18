using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topdownchase : MonoBehaviour
{
    private Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
