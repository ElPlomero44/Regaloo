using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestCafe : MonoBehaviour, IInteractable
{
    public Text textoCafe;
    float estado = 0f;
    bool interactuo = false;
    public GameObject cafe;

    public void Interact()
    {

        textoCafe.text = "Esperando";
        interactuo = true;



    }

    void Update()
    {
        if (interactuo == true)
        {
            estado += Time.deltaTime;

         

            if (estado > 5f)
            {

                textoCafe.text = "Tomate el cafe (Q)";
                cafe.SetActive(true);


                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Destroy(cafe);
                    interactuo = false;
                    Destroy(textoCafe);
                }
            }
        }
    }
}

    


