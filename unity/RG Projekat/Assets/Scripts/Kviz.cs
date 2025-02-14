using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kviz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ne ucitava nikako?");
    }

    public void loadajKviz(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Kviz");
    }

    public void loadajTutorijal(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorijal");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
