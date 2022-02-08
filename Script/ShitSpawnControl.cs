using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShitSpawnControl : MonoBehaviour
{
    public GameObject shit;
    private GameObject[] spawnPoint;
    public float minShit = 4;
    public float maxShit = 7;
    private float lastShit = 0;
    private float shitTime = 0;
    private GameObject[] Target;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("ShitSpawn");
        UpdateShit();
        Target = GameObject.FindGameObjectsWithTag("Target");
    }
    void UpdateShit()
    {
        lastShit = Time.time;
        shitTime = Random.Range(minShit, maxShit);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= lastShit + shitTime)
        {
            ShitSpawn();
        }
    }
    void ShitSpawn()
    {
        int point = Random.Range(0, spawnPoint.Length);
        GameObject shits = Instantiate(shit, spawnPoint[point].transform.position, Quaternion.identity) as GameObject;
        shits.GetComponent<ShitControl>().target = Target[point].transform.position;
        Destroy(shits, 3);
        UpdateShit();
    }
}
