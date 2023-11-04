using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public GameObject[] planet;
    private GameObject[] spawnPoint;
    private float minSpawnTime = 0.5f;
    private float maxSpawnTime = 2;
    private float lastSpawnTime = 0;
    private float spawnTime = 0;
    private int oldPoint;
    private int point;
    private GameObject gameController;
    private int checkPoint = 10;
    private int check;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("Spawn");                  
        UpdateSpawn();
        oldPoint = 0;
        gameController = GameObject.FindGameObjectWithTag("GameController");
        check = Random.Range(checkPoint -3, checkPoint+3);
    }    
    void UpdateSpawn()
    {
        lastSpawnTime = Time.time;
        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        oldPoint = point;
    }
    void Spawn()
    {
        point = Random.Range(0, spawnPoint.Length);
        spawnSpeed();
        if(point != oldPoint && point != oldPoint +2 && point != oldPoint -2 && point != oldPoint + 1 && point != oldPoint - 1)
        {
            int planetspawn = Random.Range(0, planet.Length);
            GameObject c = Instantiate(planet[planetspawn], spawnPoint[point].transform.position, Quaternion.identity);
            UpdateSpawn();
        }        
    }

    void spawnSpeed()
    {
        if (gameController.GetComponent<GameController>().gameScore > check)
        {
            if(maxSpawnTime > 1)
            {
                maxSpawnTime = maxSpawnTime - 0.1f;
            }
            checkPoint = checkPoint + 10;
            check = Random.Range(checkPoint - 3, checkPoint + 3);
        }
    }    
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= lastSpawnTime+spawnTime)
        {
            Spawn();
        }
    }
}
