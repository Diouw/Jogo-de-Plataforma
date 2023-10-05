using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptJogo : MonoBehaviour
{

    private float pausado;

    // Start is called before the first frame update
    void Start()
    {
        pausado = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (pausado == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pausado = 1;
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pausado = 0;
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(2);
            }
        }
        
    }
}
