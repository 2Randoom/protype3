using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    private float speed = 30;
    private float leftbound = -10f;
    private playercontoler playControllerscript;
    // Start is called before the first frame update
    void Start()
    {
        playControllerscript = GameObject.Find("player").GetComponent<playercontoler>();
    }

    // Update is called once per frame
    void Update()
    {
         
        if (playControllerscript.gameover == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftbound && gameObject.CompareTag("obsticle"))
        {
            Destroy(gameObject);
        }
    }
}
