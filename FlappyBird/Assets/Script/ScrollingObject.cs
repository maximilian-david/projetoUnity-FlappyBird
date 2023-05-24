using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rdb2;
    // Start is called before the first frame update
    void Start()
    {
        rdb2 = GetComponent<Rigidbody2D>();
        rdb2.velocity = new Vector2(Gamecontrol.gameControl.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamecontrol.gameControl.gameOver)
        {
            rdb2.velocity = Vector2.zero;

        }
    }
}
