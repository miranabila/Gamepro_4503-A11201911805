using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lompat : MonoBehaviour
{
    public float jump;
    bool berdiri = true;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) {
            if (berdiri) {
                GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jump);
            }
        }
        
    }
}
