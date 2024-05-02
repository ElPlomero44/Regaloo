using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestCompu : MonoBehaviour , IInteractable
{
    public GameObject fondo;
    public GameObject video;
    public GameObject jugar;
    bool fondo1 = true;
    bool video1 = false;
    bool jugar1 = false;
    bool conta = false;
    bool conta2 = false;
    public Text textVideo;
    public Text textJugar;
    public GameObject textApagar;
    public GameObject textDormir;
    public GameObject apagado;
    public Material skyMaterial;
    public GameObject Luz1;
    public GameObject Luz2;
    float contador;
    float contador2;
    public GameObject luzz;
    public void Interact()
    {
        fondo.SetActive(false);

        if (fondo1 == true)
        {
            
            video.SetActive(true);
            conta = true;
            Destroy(textVideo);

        }
        if(video1 == true)
        {
            fondo1 = false;
            video.SetActive(false);
            jugar.SetActive(true);
            Destroy(textJugar);
            conta2 = true;
        }
        if(jugar1 == true)
        {
            video1 = false;
            textApagar.SetActive(false);
            textDormir.SetActive(true);
            apagado.SetActive(true);
            jugar.SetActive(false);
        }

    }
    void Update()
    {
        if(conta == true)
        {
            contador += Time.deltaTime;
        }

        if(contador >= 10f)
        {
            video1 = true;

        }
        if(conta2 == true)
        {
            contador2 += Time.deltaTime;

        }
        if(contador2 >= 10f)
        {
            RenderSettings.skybox = skyMaterial;
            Luz2.SetActive(true);
            Luz1.SetActive(false);
            luzz.SetActive(true);
            jugar1 = true;
            conta = false;
            contador = 0f;
            conta2 = false;
           
            if(video1 == true)
            {
                textApagar.SetActive(true);
            }
            
        }
    }
}
