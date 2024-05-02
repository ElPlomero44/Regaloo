using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestDormir :  MonoBehaviour ,   IInteractable
{
    public void Interact()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    // Update is called once per frame
    void Update()
    {
        

    }
}
