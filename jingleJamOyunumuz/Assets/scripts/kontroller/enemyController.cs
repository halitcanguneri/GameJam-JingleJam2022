using System.Collections;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    // Karakterinizin transform component'ini bu de�i�kende saklay�n
    public Transform player;
    private int count=0;
    public float korkutmasuresi;

    // D��man�n h�z�n� ayarlamak i�in bir de�i�ken
    public float speed = 2f;

    // D��man�n hareket etmesini sa�lamak i�in FixedUpdate() fonksiyonunu kullan�n
    void Update()
    {
        // E�er G tu�una bas�lm��sa...
        if (Input.GetKeyDown(KeyCode.G) && count==0)
        {
            StartCoroutine(MyCoroutine());
            // ... d��man�n h�z�n� tersine �evirin
        }
        
    }
    IEnumerator MyCoroutine()
    {
        // Coroutine'un ilk k�sm�n� �al��t�r�n
        Debug.Log("Coroutine ba�lad�");
        speed = -speed;

        // Coroutine'un ikinci k�sm�n� 5 saniye sonra �al��t�r�n
        yield return new WaitForSeconds(korkutmasuresi);
        Debug.Log("Coroutine B�TMES� LAZIM ");
        StopCoroutine(MyCoroutine());
        speed = -speed;


    }

    //void FixedUpdate()
    //{
    //    // E�er karakterinizin sa��nda ise...
    //    if (transform.position.x < player.position.x)
    //    {
    //        // ... d��man� sa�a do�ru hareket ettirin
    //        transform.position += Vector3.right * speed * Time.deltaTime;
    //    }
    //    // E�er karakterinizin solunda ise...
    //    else
    //    {
    //        // ... d��man� sola do�ru hareket ettirin
    //        transform.position += Vector3.left * speed * Time.deltaTime;
    //    }
    //    if (Input.GetAxisRaw("Horizontal") == -1)
    //    {
    //        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    //    }
    //    else if (Input.GetAxisRaw("Horizontal") == 1)
    //    {
    //        transform.rotation = Quaternion.Euler(0f, 0, 0f);
    //    }
    //}
}
