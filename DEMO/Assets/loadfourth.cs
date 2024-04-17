using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadfourth : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene("FourthScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
