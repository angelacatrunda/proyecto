using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    // Start is called before the first frame update // Índice de la nueva escena
    public int indiceDeLaNuevaEscena;

    // Método llamado cuando se hace clic en el botón
    public void StartButton()
    {
        // Cambiar a la nueva escena utilizando el índice
        SceneManager.LoadScene(indiceDeLaNuevaEscena);
    }
}
