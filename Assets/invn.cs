using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class invn : MonoBehaviour
{
    public Canvas i;
    public Text Listas;
    public Text Listass;
    private int q = 0;
    private int qq = 0;
    private string p = "";

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("redd"))
        {
            q = q + 1;
            if (q == 1)
            {
                p = "";
            }
            else
            {
                p = "s";

            }
            Listass.text = "\r\n" + q + " Maçã" + p;
        }

        if (other.gameObject.CompareTag("bluee"))
        {
            qq = qq + 1;
            if (qq == 1)
            {
                p = "";
            }
            else
            {
                p = "s";

            }
            Listass.text = "\r\n" + q + " Penca de Banana" + p;
        }

        if (Listass.text == Listas.text)
        {
            i.gameObject.SetActive(true);
        }

    }
}
