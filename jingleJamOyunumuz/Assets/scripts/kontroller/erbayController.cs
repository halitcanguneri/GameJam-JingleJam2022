using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class erbayController : MonoBehaviour
{
    Rigidbody2D rb;
    public int Force;
    public int zýplama;
    public bool isDead;
    public GameObject DeathScreen;
    public GameObject kazanmaekraný;
    Vector3 velocity;
    public GameObject noelbaba;
    public GameObject anakarakter;
    public bool isFacingRight=true;
    public float horizontalInput;
    public GameManager managerGame;


    public bool isnoelbaba = false;
    public bool isdead;

    

    // Start is called before the first frame update


    // Update is called once per frame

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.H))
        {

            anakarakter.SetActive(!anakarakter.activeSelf);
            noelbaba.SetActive(!noelbaba.activeSelf);


        }
        horizontalInput = Input.GetAxisRaw("Horizontal");


        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * Force * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && noelbaba.activeSelf) 
        {
            rb.AddForce(Vector3.up * zýplama, ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Jump") && rb.IsTouchingLayers(LayerMask.GetMask("Ground")) && anakarakter.activeSelf)
        {
            rb.AddForce(Vector3.up * zýplama, ForceMode2D.Impulse);
        }

        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
        //if (Input.GetAxisRaw("Horizontal") == -1 )
        //{
        //    transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        //}
        //else if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    transform.rotation = Quaternion.Euler(0f, 0, 0f);
        //}
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deatharea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }

        if (collision.gameObject.tag == "newlevel")
        {
            isDead = true;
            Time.timeScale = 0;
            kazanmaekraný.SetActive(true);

        }
    }
    
}
