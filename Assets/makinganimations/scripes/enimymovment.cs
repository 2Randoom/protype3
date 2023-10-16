using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enimymovment : MonoBehaviour
{

    public Vector3 scale;
    public float sizeMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale = Vector3.one * 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            sizeMultiplier += 1;
            transform.localScale = Vector3.one * sizeMultiplier;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            sizeMultiplier -= 1;
            transform.localScale = Vector3.one * sizeMultiplier;
        }
    }
   
}
