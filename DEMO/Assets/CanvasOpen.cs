using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasOpen : MonoBehaviour
{
    public GameObject player; //The object with the "playermovement"
    birbfly script; //The playermovement script
    public GameObject Inspect; //The object "Game Over" of the Canvas

    void Start()
    {
        Inspect.SetActive(false);
        script = player.GetComponent<birbfly>();
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            script.enabled = false;
            Inspect.SetActive(true);
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.U) && Inspect.activeSelf)

        {
            Inspect.SetActive(false);
            script.enabled = true;
        }
    }
}
