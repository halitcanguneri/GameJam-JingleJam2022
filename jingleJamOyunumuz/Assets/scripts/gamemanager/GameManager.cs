using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void death()
    {
        Time.timeScale = 0;
    }
    public void newlevel()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("new level ge�ildi");
    }
    
    public void Restrat()
    {
        SceneManager.LoadScene(0);
    }
    public void kazanmaekran�()
    {
        SceneManager.LoadScene(1);
    }
}
