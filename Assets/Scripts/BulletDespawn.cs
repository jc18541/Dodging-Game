using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{
    //Grab the boxcollider from the current gameobject
    //Check what is being collided with
    //If colliding with anything that currently has the "Despawner" tag
        //Delete this object

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("Should be dead");
        }
    }
}
