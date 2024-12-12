using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public GameObject targetImage;


    public void ToggleImageVisibility()
    {
        if (targetImage != null)
        {
            bool isActive = targetImage.activeSelf;
            targetImage.SetActive(!isActive);
        }
        else
        {
            Debug.LogWarning("No se ha asignado ninguna imagen en el Canvas.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Juego"); 
        }
    }

    public void Exit()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
