using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreRepite : MonoBehaviour
{
    public Text frase;
    public Text textMoreRepeat;

    string fraseEscrita;
    char[] charArr;
    int maxRepeat;

    char letraMasRepetida;
    int cantidadDeVecesRepetida = 1;

    // Start is called before the first frame update
    void Start()
    {
        maxRepeat = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LetraRepetida()
    {
        fraseEscrita = frase.text;
        charArr = fraseEscrita.ToCharArray();

        int [] contadorA = new int [charArr.Length];

        for (int i = 0; i < charArr.Length; i++)
        {
            contadorA[i] = 0;
            maxRepeat = 1;

            

            for (int j = 0; j < charArr.Length; j++)
            {
                if (charArr[i] == charArr[j])
                {
                    contadorA[i]++;
                    if (contadorA[i] > maxRepeat)
                    {
                        maxRepeat = contadorA[i];
                        Debug.Log(charArr[i] + " se repite: " + maxRepeat);

                        if (maxRepeat > cantidadDeVecesRepetida)
                        {
                            cantidadDeVecesRepetida = maxRepeat;
                            letraMasRepetida = charArr[i];
                        }
                    }
                }

            }
            Debug.Log("Letra mas repetida: " + letraMasRepetida + " veces: " + cantidadDeVecesRepetida);
            textMoreRepeat.text = "\"" + letraMasRepetida + "\"" + " >> Cantidad de veces: " + cantidadDeVecesRepetida;
        }
    }
}
