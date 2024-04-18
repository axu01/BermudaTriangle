using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadbosschase : MonoBehaviour
{
    // Start is called before the first frame update
    public void birdfeed()
    {
        SceneManager.LoadScene("bosschase");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
