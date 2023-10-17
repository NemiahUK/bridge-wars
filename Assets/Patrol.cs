using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

public float patrolSpeed = 3.0f;
public float minPosition = -8.0f;
public float maxPosition = 8.0f;

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * patrolSpeed);

        if (transform.position.x > maxPosition)
        {
            transform.Rotate(0, 180, 0);
            transform.position = new Vector3(maxPosition, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < minPosition)
        {
            transform.Rotate(0, 180, 0);
            transform.position = new Vector3(minPosition, transform.position.y, transform.position.z);
        }
    }
}
