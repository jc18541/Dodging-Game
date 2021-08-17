using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogic : MonoBehaviour
{
    //Create an array containing each of the 4 spawners
    //Make


    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;

    public GameObject bulletX;
    public GameObject bulletY;


    //Dont really need the spawners in
    //Just need the y/x of the spawn points
    //Can then pick a random position on these spawn points to spawn a bullet


    //Dont even need it to be an arraylist
    //Can just pick a random number between 1 and 4



    private GameObject[] spawnerArray = new GameObject[4];

    public float spawnrate = 5;
    private int objSpawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnerArray[0] = spawner1;
        spawnerArray[1] = spawner2;
        spawnerArray[2] = spawner3;
        spawnerArray[3] = spawner4;
        InvokeRepeating("spawnFunction", 1, spawnrate); //Doing the decreasing thing just isn't working here, will have to figure something else out later
    }

    private float nextAction = 0.0f;
    public float period = 100f;

   

    private void Update()
    {
    }

    private void spawnFunction()
    {
        int randRange;
        //Just try spawning every time this is called, see what happens
        randRange = Random.Range(1, 4);
        if (randRange <= 2)
        {
            Instantiate(bulletX, new Vector3(spawnerArray[randRange - 1].transform.position.x, Random.Range(5, -5), 0), new Quaternion());
        }
        else
        {
            Instantiate(bulletY, new Vector3(Random.Range(-8, 8), spawnerArray[randRange - 1].transform.position.y, 0), new Quaternion());
        }
    }
}
