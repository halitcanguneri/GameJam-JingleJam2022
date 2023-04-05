using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telefonluDusmanController : MonoBehaviour
{
    public int telefonHiz;
    public GameObject telefonPrefab;
    public Transform telefonyeri;
    void Start()
    {
        _ = GetComponent<Rigidbody2D>();
        // Bu sat�r, "FireArrow" fonksiyonunu her 5 saniyede bir �a��r�r
        
        InvokeRepeating("FireArrow", 2f, 3f);
    }


    
    void FireArrow()
    {
        
        
        GameObject newtel = Instantiate(telefonPrefab, telefonyeri.transform.position, Quaternion.Euler(0, 0, 0));
        // mermi nesnesinin hareket ettirilmesi i�in kuvvet uygulay�n
        newtel.GetComponent<Rigidbody2D>().AddForce(Vector2.left * telefonHiz, ForceMode2D.Impulse);

        Destroy(newtel, 2f);

    }

    
}
