using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    Rigidbody2D aff;

    // Start is called before the first frame update
    void Start()
    {
        aff = GetComponent<Rigidbody2D> ();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate (){
        float move = Input.GetAxis("Horizontal");
        aff.velocity = new Vector2 (speed*move, aff.velocity.y);
    }
}
