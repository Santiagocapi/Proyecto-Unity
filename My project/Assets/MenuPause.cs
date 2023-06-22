using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool pausedGame = false;

    private void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (pausedGame)
            {
                Resume();
            }else{
                Pause();
            }
        }
    }

   public void Pause ()
   {
       pausedGame = true;
       Time.timeScale = 0f;
       botonPausa.SetActive(false);
       menuPausa.SetActive(true);
   }

   public void Resume()
   {
       pausedGame = false;
       Time.timeScale = 1f;
       botonPausa.SetActive(true);
       menuPausa.SetActive(false);
   }

   public void Reset ()
    {
        pausedGame = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit ()
    {
        Debug.Log("Juego Cerrado");
        Application.Quit();
    }
}
