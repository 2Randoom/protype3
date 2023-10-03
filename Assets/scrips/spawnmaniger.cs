using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmaniger : MonoBehaviour
{
    public float startDelay;
    public float reapetrate;


    public GameObject Obstacleprefab;
    private Vector3 spawnpos = new Vector3 (25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, reapetrate);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        Instantiate(Obstacleprefab, spawnpos, Obstacleprefab.transform.rotation);
    }
}
