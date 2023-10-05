using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControlador : MonoBehaviour
{
    
    public void iniciar(){
        SceneManager.LoadSceneAsync(1);
        Time.timeScale = 1;
    }


    public void sair(){

        Application.Quit();
    }

    public void menu(){

        SceneManager.LoadSceneAsync(0);
    }
}
