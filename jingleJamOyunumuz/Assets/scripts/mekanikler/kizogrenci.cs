using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kizogrenci : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "sesdalgas�")
        {
            Debug.Log("asdfasd");
            Destroy(collision.gameObject);
            
        }

    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
