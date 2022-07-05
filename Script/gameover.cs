using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class  gameover : MonoBehaviour
{

    public AudioSource bav;

    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = "" + score;
    }
    public void Setup()
    {
        bav.Play();

        gameObject.SetActive(true);
    }
    public void restartButton()
    {
        //SoundManagerScript.PlaySound("gameover");
        bav.Play();
        SceneManager.LoadScene("mainmenu");
    }
    public void QuitButton()
    {
        bav.Play();
        Application.Quit();
    }
}
