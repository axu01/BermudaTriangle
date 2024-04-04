using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclickload : MonoBehaviour
{
    // Start is called before the first frame update
    public void clickyclick()
    {
        SceneManager.LoadScene("SecondScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
