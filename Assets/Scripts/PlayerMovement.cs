using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 0.01f;


    //Get the input of the player
    void Update()
    {
        //rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
    }

    //Move the player by adjusting the rigidbody
    private void FixedUpdate()
    {
        rb.position += new Vector2((Input.GetAxis("Horizontal") * speed), (Input.GetAxis("Vertical") * speed));
        //rb.AddForce(new Vector2((Input.GetAxis("Horizontal") * speed) * Time.deltaTime , (Input.GetAxis("Vertical") * speed) * Time.deltaTime));
    }
}