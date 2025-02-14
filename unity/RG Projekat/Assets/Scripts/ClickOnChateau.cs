using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnChateau : MonoBehaviour
{
    public GameObject objekat; //javni parametar
    Ray ray; // deklaracija varijable Ray
    RaycastHit hit; // deklaracija varijable RaycastHit
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // provjeri da li se desio dodir
        if(Input.GetMouseButtonDown(0))
        {
                // šalje se zraka od mjesta gdje je ekran dotaknut
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // provjera da li je neki objekat pogođen i upisuje ga u hit ako jeste
            if(Physics.Raycast(ray, out hit))
            {
                // pristupamo tag-u collidera na objektu koji je pogođen zrakom
                if(hit.collider.tag == "dvorac")
                {
                    if(objekat.activeSelf)
                    //ako je objekat aktivan, sakrij ga
                    objekat.SetActive(false);
                    else
                    // ako objekat nije aktivan, prikaži ga
                    objekat.SetActive(true);
                }
            }
        }
    }
}
