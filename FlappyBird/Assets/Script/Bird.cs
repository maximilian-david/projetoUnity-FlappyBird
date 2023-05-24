using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 0;

    private bool taMorto = false;

    private Rigidbody2D rdb2;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rdb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!taMorto)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rdb2.velocity = Vector2.zero;
                rdb2.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }

        rdb2.position = new Vector2(rdb2.position.x, Mathf.Clamp(rdb2.position.y, rdb2.position.y, 4.7f));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rdb2.velocity = Vector2.zero;
        taMorto = true;
        anim.SetTrigger("Morreu");
        Gamecontrol.gameControl.BirdDie();
    }
}
