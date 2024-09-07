using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class camera : MonoBehaviour
{
    public Transform hedef;
    public Vector3 Mesafe;
    [SerializeField]
    private float Sensivity;
    float fareX,fareY;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
     private void LateUpdate()
    {
        this.transform.position =Vector3.Lerp(this.transform.position,hedef.position+Mesafe,Time.deltaTime*10);
        fareX += Input.GetAxis("Mouse X")*Sensivity;
        fareY += Input.GetAxis("Mouse Y")*Sensivity;
        this.transform.eulerAngles=new Vector3(fareY,fareX,0);
        hedef.transform.eulerAngles =new Vector3(0,fareX,0);

        if (fareY >= 40)
        {
            fareY = 40;
        }
        if (fareY <= 0)
        {
            fareY = 0;
        }
    }  
}
