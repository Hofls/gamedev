using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float secondsPerSpawn;
    public float heightOffset;
    private float secondsSinceSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (secondsSinceSpawn < secondsPerSpawn)
        {
            secondsSinceSpawn = secondsSinceSpawn + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            secondsSinceSpawn = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint= transform.position.y + heightOffset;
        var vector = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint));
        Instantiate(pipe, vector, transform.rotation);
    }

}
