using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("Eigth Scene Transition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
