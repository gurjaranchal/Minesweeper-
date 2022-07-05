using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamelevel : MonoBehaviour
{
    public static double threshhold;
    public static int  starttime;
    public AudioSource s;
    // Start is called before the first frame update
    public void easy()
    {
     // s.Play();
        threshhold = 0.10;
        starttime = 60;
        SceneManager.LoadScene("minesweeper");
    }
    public void medium()
    {
       //.Play();
        threshhold = 0.20;
        starttime = 40;
        SceneManager.LoadScene("minesweeper");
    }
    public void hard()
    {
       //.Play();
        threshhold = 0.30;
        starttime = 20;
        SceneManager.LoadScene("minesweeper");
    }
}
