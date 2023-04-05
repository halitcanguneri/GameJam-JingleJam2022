using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesDalgasi : MonoBehaviour
{
    public Transform nokta;
    public float hizmermi = 10f; // mermi nesnesinin hareket h�z�n� ayarlay�n
    
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
                // mermi nesnesinin hareket ettirilmesi i�in kuvvet uygulay�n
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-hizmermi, 0), ForceMode2D.Impulse);
                mermiAtildi = true; // mermi at�ld���n� belirten de�i�keni true olarak ayarlay�n
                

                
            }
            else if (erbay.isFacingRight)
            {
                GameObject bullet = Instantiate(obje, nokta.transform.position, Quaternion.Euler(0f, 0, 90f));
                // mermi nesnesinin hareket ettirilmesi i�in kuvvet uygulay�n
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(hizmermi, 0), ForceMode2D.Impulse);
                mermiAtildi = true; // mermi at�ld���n� belirten de�i�keni true olarak ayarlay�n

                
            }
            // mermi nesnesinin olu�turulmas�
            
        }
    }
}
