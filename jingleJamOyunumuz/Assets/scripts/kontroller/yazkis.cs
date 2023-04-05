using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yazkis : MonoBehaviour
{
    public GameObject yaz;
    public GameObject kis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {

            
            yaz.SetActive(!yaz.activeSelf);
            kis.SetActive(!kis.activeSelf);

        }

    }
}
