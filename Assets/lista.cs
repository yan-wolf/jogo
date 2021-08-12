using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lista : MonoBehaviour
{
   
    public Text Listas;
    public Text Listass;
    private int intelligence = 5;
    private int quantidade = 0;
    private string plural = "";
    public void ale()
    {
        intelligence = Random.Range(0, 5);
        quantidade = Random.Range(1, 7);
        if (quantidade == 1)
        {
            plural = "";
        }
        else { 
            plural = "s";

        }

        intelligence = 4;
        quantidade = 3;

        switch (intelligence)
        {
            case 5:
                if (Listas.text.Contains("Banana")) { }
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Penca de Banana" + plural;
                }
                break;
            case 4:
                if (Listas.text.Contains("Maçã")) { }
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Maçã" + plural;
                }
                break;
            case 3:
                if (Listas.text.Contains("Morango")){}
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Caixa" + plural + " de Morango";
                }
                    break;
            case 2:
                if (Listas.text.Contains("Umbu")) { }
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Bacia" + plural + " Umbu";
                }
                break;
            case 1:
                if (Listas.text.Contains("Uva")) { }
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Bacia" + plural + " Uva";
                }
                break;
            default:
                if (Listas.text.Contains("Pera")) { }
                else
                {
                    Listas.text = Listas.text + "\r\n" + quantidade + " Pera" + plural;
                }
                
                break;


        }

    }


    // Start is called before the first frame update
    void Start()
    {
        ale();
        


    }

    // Update is called once per frame
    void Update()
    {

         
    


    }
}
