using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptSidd : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
        }
    }
}
