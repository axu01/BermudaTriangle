using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadeigth : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
