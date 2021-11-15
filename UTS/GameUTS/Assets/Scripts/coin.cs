using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour{
    void OnCollisionEnter2D (Collision2D col){
        if (col.gameObject.tag.Equals ("player")) {
            print("coin diambil");
            Destroy (gameObject);
            score.hitungCoin += 10;
        }
    }

}
