using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repetingBalkground : MonoBehaviour
{
    private Vector3 StartPos;
    private float ReapetWith;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        ReapetWith = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < StartPos.x - ReapetWith) 
        {
            transform.position = StartPos;
        }
    }
}
