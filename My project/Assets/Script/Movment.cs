using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class InputHandler : MonoBehaviour
{
    public float yondad; // -1 geri +1 ileri
    public float speed = 5.0f;
 
    void Start()
    {
        
    }

    void Update()
    {
        // Yatay eksende hareket (x ekseni)
        yondad = Input.GetAxis("Horizontal");
        this.transform.Translate(new Vector3(yondad * speed * Time.deltaTime, 0, 0));

        // Dikey eksende değil, z ekseninde hareket
        yondad = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(0, 0, yondad * speed * Time.deltaTime));
    }
   
}   

