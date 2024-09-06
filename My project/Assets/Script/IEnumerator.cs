using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    public GameObject nesne;
    public bool dead;

    void Start()
    {
        if(dead==true)
        {
            StartCoroutine(olursturyoket());
        }
        
    }

    void Update()
    {
        
    }

    IEnumerator olursturyoket()
    {
        GameObject temp = Instantiate(nesne);
        yield return new WaitForSeconds(3);
        Destroy(temp);
    }
}
