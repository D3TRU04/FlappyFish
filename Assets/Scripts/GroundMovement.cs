using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    float groundLength;
    BoxCollider2D groundCollider;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2 (transform.position.x - speed * Time.deltaTime, transform.position.y);

        if(transform.position.x <= -groundLength) {
            transform.position = new Vector2(transform.position.x + 2 * groundLength, transform.position.y);
        }
    }
}
