using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementX : MonoBehaviour
{
    //Doing the same as in BulletMovementY, only adjusting for the x axis


    private bool isLeft; //Should be true if the bullet is to the left of the player
    public float moveSpeed = 5f;

    //public GameObject player; //Trying to find the player gameobject
    GameObject player;


    //Checking if the bullet is above or below the player and setting isAbove to the appropriate value
    void Start()
    {
        player = GameObject.Find("Player");
        if (transform.position.x < player.transform.position.x)
        {
            isLeft = true;
        }
        else
        {
            isLeft = false;
        }
    }

    

    //Want to move the player here
    private void FixedUpdate()
    {
        if (isLeft)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }
}
