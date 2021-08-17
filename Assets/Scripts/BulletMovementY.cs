using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementY : MonoBehaviour
{
    //In start, should check which side of the bullet the player is
    //Use a bool to check
    //Should move up if player is above, should move down if player is below

    //Should keep moving
    //Create a collider later which will despawn the bullet
    //Until then, have the bullet move infinitely


    private bool isAbove; //Should be true if the bullet is above the player
    public float moveSpeed = 5f;

    GameObject player; //Trying to find the player gameobject
    

    //Checking if the bullet is above or below the player and setting isAbove to the appropriate value
    void Start()
    {
        player = GameObject.Find("Player");
        if(transform.position.y > player.transform.position.y)
        {
            isAbove = true;
        }
        else
        {
            isAbove = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Want to move the player here
    private void FixedUpdate()
    {
        if(isAbove)
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
    }
}
