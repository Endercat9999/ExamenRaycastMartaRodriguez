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
                        StartCoroutine(CuentaAtras());
                    }
                    else if(hit.transform.tag == "cubo 2")
                    {
                        StartCoroutine(CuentaAtras2());   
                    }
                    else if(hit.transform.tag == "esfera")
                    {
                        StartCoroutine(CuentaAtras3()); 
                    }

                    Debug.Log(hit.transform.name);
            }
        }

    IEnumerator CuentaAtras()
        {
            cuentaAtrasTextos.text = "5";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "4";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "3";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "2";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "1";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "0";
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene("Scene1 1");

        }

    IEnumerator CuentaAtras2()
        {
            cuentaAtrasTextos.text = "5";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "4";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "3";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "2";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "1";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "0";
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene("Scene1 2");

        }

    IEnumerator CuentaAtras3()
        {
            cuentaAtrasTextos.text = "5";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "4";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "3";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "2";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "1";
            yield return new WaitForSeconds(1);
            cuentaAtrasTextos.text = "0";
            yield return new WaitForSeconds(1);

            SceneManager.LoadScene("Scene1 3");

        }

    }





}
