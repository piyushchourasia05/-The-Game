using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starttoone : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }
    public void Scene2()
    {
        SceneManager.LoadScene(4);
    }
    public void exitgame()
    {
       
        Application.Quit();
    }
}
