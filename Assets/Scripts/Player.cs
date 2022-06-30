using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 moveDelta;

    void Start() {
        
    }

    void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDelta = new Vector3(x, y);

        Debug.Log("H: "+x);
        Debug.Log("V: "+y);
        // transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
    }
}
