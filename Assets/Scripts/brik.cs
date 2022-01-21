using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brik : MonoBehaviour
{

    public int hits = 1;
    public int points = 100;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;

        if (hits <= 0) 
        {
            Destroy(gameObject);  
        }
    }

}
