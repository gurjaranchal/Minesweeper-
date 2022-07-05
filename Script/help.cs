using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class help : MonoBehaviour
{
    public AudioSource ba;
    public void Setup()
    {
        ba.Play();
        gameObject.SetActive(true);
    }
    public void exit()
    {
        ba.Play();
        Debug.Log("exit the help");
        gameObject.SetActive(false);
    }

}
