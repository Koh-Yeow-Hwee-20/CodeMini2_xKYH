using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeZPosition : MonoBehaviour
{
    float speed;
    float zLimit = 20.0f;
    float xLimit = 0f;

    bool isBouncing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(2.0f, 10.0f);

        //Step 1 of divide and conquer
        if (transform.position.z < zLimit && isBouncing)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (transform.position.z > -xLimit && !isBouncing)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        }
        else
        {
            isBouncing = !isBouncing;
        }
        
    }
    //Keeps the ball on the platform
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }

}
