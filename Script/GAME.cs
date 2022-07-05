using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAME : MonoBehaviour
{
    public AudioSource bo;
    // Start is called before the first frame update
    public void Startgame()
    {



        
        SceneManager.LoadScene("gamelevel");
        

    }

    // Update is called once per frame
   public void quit()
    {
        
        Application.Quit();
    }
}
