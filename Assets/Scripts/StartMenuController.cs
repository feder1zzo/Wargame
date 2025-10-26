using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    //Botón 'Nueva Partida'
    public void OnStartClick ()
    {
        SceneManager.LoadScene("NewScene");

    }

    //Botón 'Salir'

    public void OnExitClick ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
