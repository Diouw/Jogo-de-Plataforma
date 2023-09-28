using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptInimigo : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;
    private Animator anim;
    private bool esq = true;
    public float posX1 = 5.23f;
    public float posX2 = 12.7f;

    void Start()
    {
        vel = -5;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rbd.velocity = new Vector2(vel, rbd.velocity.y);

        if(transform.position.x <= posX1 && esq){
            esq = false;
            vel = vel * -1;
            transform.Rotate(0, 180, 0);
        }
        if(transform.position.x >= posX2 && esq==false){
            esq = true;
            vel = vel * -1;
            transform.Rotate(0, 180, 0);
        }

    }
}
