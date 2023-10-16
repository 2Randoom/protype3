using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    //movement vareables
    private float vertialInput;
    public float movespeed;

    public float horizontalInput;
    public float turnspeed;
    // jumping variables
    private Rigidbody rb;
    public float jumpforce;
    public bool isOnGround;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        vertialInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * movespeed * vertialInput);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * horizontalInput);
        
        animator.SetFloat("VerticalInput", Mathf.Abs(vertialInput));
      
        //make the player jump and play the animation for the jump 
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
           isOnGround = false;
          
            animator.SetBool("isonground", isOnGround);
        }
        //play the attack animation
                if (Input.GetKeyDown(KeyCode.Q))
                {
                  animator.SetTrigger("attack");
                }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            animator.SetBool("isonground", isOnGround);
        }
    }

}
