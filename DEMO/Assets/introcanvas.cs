using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introcanvas : MonoBehaviour
{
    public Canvas CanvasObject; // Assign in inspector
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
        }
    }
}
