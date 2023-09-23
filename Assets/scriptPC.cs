using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rbd;
    public float vel;
    public float pulo = 500;
    private Animator anim;
    private bool dir = true;

    public GameObject pe;
    public LayerMask mascara;
    private bool chao;

    


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


        if (Input.GetKeyDown(KeyCode.Space) && chao) {
            rbd.AddForce(new Vector2(0, pulo));
        }
        RaycastHit2D hit;
        hit = Physics2D.Raycast(pe.transform.position,
            -pe.transform.up,
            0.1f,
            mascara);

        if (hit.collider != null)
        {
            chao = true;
        }
        else {
            chao = false;
        }

        //transform.Translate(new Vector2(x*Time.deltaTime, 0));

    }

}
