using System.Collections;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    // Karakterinizin transform component'ini bu deðiþkende saklayýn
    public Transform player;
    private int count=0;
    public float korkutmasuresi;

    // Düþmanýn hýzýný ayarlamak için bir deðiþken
    public float speed = 2f;

    // Düþmanýn hareket etmesini saðlamak için FixedUpdate() fonksiyonunu kullanýn
    void Update()
    {
        // Eðer G tuþuna basýlmýþsa...
        if (Input.GetKeyDown(KeyCode.G) && count==0)
        {
            StartCoroutine(MyCoroutine());
            // ... düþmanýn hýzýný tersine çevirin
        }
        
    }
    IEnumerator MyCoroutine()
    {
        // Coroutine'un ilk kýsmýný çalýþtýrýn
        Debug.Log("Coroutine baþladý");
        speed = -speed;

        // Coroutine'un ikinci kýsmýný 5 saniye sonra çalýþtýrýn
        yield return new WaitForSeconds(korkutmasuresi);
        Debug.Log("Coroutine BÝTMESÝ LAZIM ");
        StopCoroutine(MyCoroutine());
        speed = -speed;


    }

    //void FixedUpdate()
    //{
    //    // Eðer karakterinizin saðýnda ise...
    //    if (transform.position.x < player.position.x)
    //    {
    //        // ... düþmaný saða doðru hareket ettirin
    //        transform.position += Vector3.right * speed * Time.deltaTime;
    //    }
    //    // Eðer karakterinizin solunda ise...
    //    else
    //    {
    //        // ... düþmaný sola doðru hareket ettirin
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
