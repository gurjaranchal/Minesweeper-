using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text Timers;
    public static float timer = 0.0f;
    public bool isTimer = true;
    public bool timeReset = false;
    public gameover gameover;

    // Start is called before the first frame update
    void Start()
    {

        timer = Gamelevel.starttime;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        int seconds = Mathf.FloorToInt(timer+1);

        string timestring = string.Format("{00:000}", seconds);
        Timers.text = timestring;
        if (timer < 0)
        {
            timer = 001;
        }
        if (timer == 0)
        {
            gameover.Setup();
        }






    }
}
