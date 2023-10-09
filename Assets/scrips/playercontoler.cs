using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontoler : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAm;
    public float jumpforce = 10f;
    public float gravitymodifier;
    public bool isonground = true;
    public bool gameover;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAm = GetComponent<Animator>();
        Physics.gravity *= gravitymodifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isonground && !gameover) 
        {
            playerRb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
            isonground = false;
            playerAm.SetTrigger("Jump_trig");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
       

        if (collision.gameObject.CompareTag("ground"))
        {
            isonground = true;
        }else if (collision.gameObject.CompareTag("obsticle"))
        {
            Debug.Log("Gameover");
            gameover = true;
            playerAm.SetBool("Death_b", true);
            playerAm.SetInteger("DeathType_int", 1);
        }
    }
}
