using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AzulScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float jumpForce;
    private Rigidbody2D body;
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.body = GetComponent<Rigidbody2D>();
        this.body.isKinematic = true;
        this.spriteRenderer.flipX = true;
    }
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            this.body.isKinematic = false;
            this.body.AddForce(new Vector2(1, this.jumpForce));
        }
        this.transform.rotation = Quaternion.Euler(0, 0, body.velocity.y * 3);
    }
}
