using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{

    private GameObject botonPausa;
    private GameObject menuPausa;

   public void Pause ()
   {
       Time.timeScale = 0f;
       botonPausa.SetActive(false);
       menuPausa.SetActive(true);
   }

   public void Resume()
   {
       Time.timeScale = 1f;
       botonPausa.SetActive(true);
       menuPausa.SetActive(false);
   }
}
