using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeOver : MonoBehaviour
{
    //public Text TimeLeftText;
    public TMP_Text TimeLeftText;
    public int TimerTimeLeftSecond = 60;
    public bool TimeIsUp;
    public GameObject GameOverPanel;
    //dunno wat star screen does
    //public GameObject StartScreen;


    // Start is called before the first frame update
    void Start()
    {

        //coroutine = WaitAndPrint(2.0f);

        StartCoroutine(WaitAndPrint());

        GameOverPanel.SetActive(false); ;

        //Make a bool
        TimeIsUp = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    // timer needs to wait 1 second then update an int then update the text field with that new integer
    //

    IEnumerator WaitAndPrint()
    {


        while (TimerTimeLeftSecond > 0)
        {
            // timer needs to wait 1 second
            yield return new WaitForSeconds(1);

            //
            TimerTimeLeftSecond = TimerTimeLeftSecond - 1;
            //TimerTimeLeft;

            // Each phrase from my pseudocode up here will become a line of code (usually)
            print("Seconds Left " + TimerTimeLeftSecond);

            // Text field is a UI thing so we need a Canvas and a TExt field in the Unity Editor
            // And we need to use the UnityEngine.UI library in this script


            // Assign the new value to text field

            //this apply to the Legacy text
            TimeLeftText.text = TimerTimeLeftSecond.ToString(); //casting 
                                                                //this apply to the TMP text
        }

        print("Time is up");
        // Restart the level

        GameOverPanel.SetActive(true);

        //Make a bool
        TimeIsUp = true;
    }
}
