using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlayerController : MonoBehaviour
{
    //Movement Variables
    private float verticalInput;
    public float moveSpeed;

    private float horizontalInput;
    public float turnSpeed;

    //Jumping Variables
    private Rigidbody rb;
    public float jumpForce;
    public bool isOnGround;


    //animation Vareables
    private Animator animator;

    //particles
    public ParticleSystem dustcload;

    // Start is called before the first frame update
    void Start()
    {
        //Get Components
        rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        //stop the dustcload when the game starts
        dustcload.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward and Backward Movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * verticalInput);

        //acivate or deactiveat the dustcloat 
        if(verticalInput > 0 && !dustcload.isPlaying )
        {
            dustcload.Play();
        }
        else if (verticalInput <= 0) 
        {
            dustcload.Stop();
        }


        //activate run or idle animation
        animator.SetFloat("verticleInput", Mathf.Abs(verticalInput));


        //Rotation
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        //Jumping
        if(Input.GetKeyDown(KeyCode.Space)  && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            animator.SetBool("isonGround", isOnGround);
        }

        //shoot
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("shoot");
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            animator.SetBool("isonGround", isOnGround);
        }
    }
}
