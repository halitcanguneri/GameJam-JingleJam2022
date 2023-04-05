using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesDalgasi : MonoBehaviour
{
    public Transform nokta;
    public float hizmermi = 10f; // mermi nesnesinin hareket hýzýný ayarlayýn
    
    public GameObject obje;
    erbayController erbay;
    public bool mermiAtildi;

    // Start is called before the first frame update
    void Start()
    {
       
        erbay = FindObjectOfType<erbayController>();
        Rigidbody2D bullet = GetComponent<Rigidbody2D>();
    }
    
    

    // Update is called once per frame


    void Update()
    {
        
        
        
        if (Input.GetKeyDown(KeyCode.F) )
        {
            
            if (!erbay.isFacingRight)
            {
                GameObject bullet = Instantiate(obje, nokta.transform.position, Quaternion.Euler(0f, 0, -90f));
                // mermi nesnesinin hareket ettirilmesi için kuvvet uygulayýn
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-hizmermi, 0), ForceMode2D.Impulse);
                mermiAtildi = true; // mermi atýldýðýný belirten deðiþkeni true olarak ayarlayýn
                

                
            }
            else if (erbay.isFacingRight)
            {
                GameObject bullet = Instantiate(obje, nokta.transform.position, Quaternion.Euler(0f, 0, 90f));
                // mermi nesnesinin hareket ettirilmesi için kuvvet uygulayýn
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(hizmermi, 0), ForceMode2D.Impulse);
                mermiAtildi = true; // mermi atýldýðýný belirten deðiþkeni true olarak ayarlayýn

                
            }
            // mermi nesnesinin oluþturulmasý
            
        }
    }
}
