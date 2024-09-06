using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool inside;
    public float hp;
    void Start()
    {
        hp = 100;
    }

    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "TestTrigger")
        {
            inside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Serdar ");
        if (other.gameObject.tag == "TestTrigger")
        {
            inside = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            hp -= Time.deltaTime*2;
        }
    }
}

