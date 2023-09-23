using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float vel;
    private Animator anim;
    private bool dir = true;

    void Start()
    {
        vel = 10;
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rbd.velocity = new Vector2(x * vel, rbd.velocity.y);

        if (x == 0)
        {
            anim.SetBool("movendo", false);
        }
        else {
            anim.SetBool("movendo", true);
        }

        if (dir && x < 0 || !dir && x > 0)
        {
            transform.Rotate(0, 180, 0);
            dir = !dir;
        }
    }
}
