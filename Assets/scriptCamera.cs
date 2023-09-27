using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public float xOffset = 5;
    public float yOffset = 3;
    public GameObject pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pc.transform.position.y < -3){
            Vector3 pos = new Vector3(pc.transform.position.x + xOffset,    
            pc.transform.position.y + yOffset,
            -10);
            transform.position = pos;
        }
        else{
          Vector3 pos = new Vector3(pc.transform.position.x + xOffset,    
            0,
            -10);
            transform.position = pos;  
        }
        
    }
}
