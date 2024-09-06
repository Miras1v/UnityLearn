using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public bool HitWall;

    
    void Start()
    {
        HitWall = false; // Başlangıçta HitWall false olarak ayarlanabilir.
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            HitWall = true;
        }
    }
     private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            HitWall = false;
        }
    }
}
