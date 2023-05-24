using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float size = 17.8f;//rradio
    private float tamanhoHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        //groundCollider = GetComponent<BoxCollider2D>();
        //tamanhoHorizontal = groundCollider.size.x;
        tamanhoHorizontal = size;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -tamanhoHorizontal)
        {
            RespositionBackground();
        }
    }

    void RespositionBackground()
    {
        Vector2 groundOffset = new Vector2(tamanhoHorizontal * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
