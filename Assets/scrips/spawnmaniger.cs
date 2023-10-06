using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmaniger : MonoBehaviour
{
    public float startDelay;
    public float reapetrate;

    private playercontoler playercontolerscript;
    public GameObject Obstacleprefab;
    private Vector3 spawnpos = new Vector3 (25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, reapetrate);
        playercontolerscript = GameObject.Find("player").GetComponent<playercontoler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        if(playercontolerscript.gameover == false)
        {
            Instantiate(Obstacleprefab, spawnpos, Obstacleprefab.transform.rotation);
        }
        
    }
}
