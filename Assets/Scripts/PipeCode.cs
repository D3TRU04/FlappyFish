using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCode : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);

        if(transform.position.x <= -15.97333f) {
            transform.position = new Vector3(9.64f, Random.Range(-1.50f, 2.50f), transform.position.z);
        }
    }
}
