using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadARScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadARScene1(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorijal");
    }
}
