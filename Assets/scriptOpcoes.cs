using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptOpcoes : MonoBehaviour

{
    
    public void continuar(){
        SceneManager.UnloadSceneAsync(2);
        Time.timeScale = 1;
    }


    public void sair(){
        SceneManager.LoadSceneAsync(0);
    }
}
