using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class RoatateOnArrows : MonoBehaviour
{
   
    private float horRot;
    private float verRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate() {
        horRot = Input.GetAxis("Horizontal");
        verRot = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(verRot, 0.0f, -horRot),Space.Self);
    }

    
   
}

 