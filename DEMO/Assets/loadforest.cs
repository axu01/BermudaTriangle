using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadforest : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("forest chase");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
