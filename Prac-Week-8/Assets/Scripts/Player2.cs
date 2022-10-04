using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player2 : MonoBehaviour
{
    // public float moveSpeed; 
    // public Rigidbody rigi;
    // public float jumpForce;
// Use this for initialization
    // void start () 
    // {
    //     rigi = GetComponent<Rigidbody>();
    // }
    Vector3 newPosition;
    void Start () {
        newPosition = transform.position;
     }
    //Update is called once per frame
    void Update () 
    {
        
        
        // if (Input.GetMouseButtonDown(0))
        // {   
        //     rigi.velocity = new Vector3(Input.GetAxis ("Horizontal") * moveSpeed, rigi.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
            
        // }
                 if (Input.GetMouseButtonDown(0))
         {
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out hit))
             {
                 newPosition = hit.point;
                 transform.position = newPosition;
             }
         }
    }

}
