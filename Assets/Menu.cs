using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void easy()
    {

        SceneManager.LoadSceneAsync(1);


    }

    public void medium()
    {

        SceneManager.LoadSceneAsync(2);


    }



    public void hard()
    {

        SceneManager.LoadSceneAsync(3);


    }




    public void OpenUrl()
    {

        Application.OpenURL("https://github.com/Ameeshbains/GUNS-PHOBIA.git");


    }





}
