using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    Animator anim;
    public float speed = 5.0f;
 
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        Hareket();
    }
   
    void Hareket()
    {
        // Yatay ve dikey eksen hareketlerini ayrı değişkenlerde tutun
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        // Yatay eksende (x ekseni) hareket
        this.transform.Translate(new Vector3(yatay * speed * Time.deltaTime, 0, 0));

        // Z ekseninde hareket
        this.transform.Translate(new Vector3(0, 0, dikey * speed * Time.deltaTime));

        // Animasyon parametrelerini ayarla
        anim.SetFloat("Horizontal", yatay);
        anim.SetFloat("Vertical", dikey);
    }
}
