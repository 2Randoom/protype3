using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontoler : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpforce = 10f;
    public float gravitymodifier;
    public bool isonground = true;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymodifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isonground) 
        {
            playerRb.AddForce(Vector3.up * jumpforce,ForceMode.Impulse);
            isonground = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        isonground=true;

    }
}
