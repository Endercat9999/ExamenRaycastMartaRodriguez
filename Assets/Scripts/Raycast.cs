using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Raycast : MonoBehaviour
{
   public Text cuentaAtrasTextos;
   
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
              if(hit.transform.tag == "cubo 1")
                    {
                        SceneManager.LoadScene("Scene1 1");
                    }
                    else if(hit.transform.tag == "cubo 2")
                    {
                        SceneManager.LoadScene("Scene1 2");
                    }
                    else if(hit.transform.tag == "esfera")
                    {
                        SceneManager.LoadScene("Scene1 3");
                    }

                    Debug.Log(hit.transform.name);
            }
        }
    }
}
