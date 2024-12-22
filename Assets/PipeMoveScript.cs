using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float moveScript = 5;
    public float deadZone = -45;



    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveScript) * Time.deltaTime;

        if(transform.position.x < deadZone )
        {
            Debug.Log("Pipe Deleted!");
            Destroy(gameObject);
        }
    }
}

