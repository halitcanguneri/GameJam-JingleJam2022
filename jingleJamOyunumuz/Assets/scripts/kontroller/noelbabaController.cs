using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noelbabaController : MonoBehaviour
{
    Rigidbody2D rb;
    public int Force;
    public int zýplama;
    Vector3 velocity;

    // Start is called before the first frame update


    // Update is called once per frame

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * Force * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && rb.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            rb.AddForce(Vector3.up * zýplama, ForceMode2D.Impulse);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0, 0f);
        }
    }
}
