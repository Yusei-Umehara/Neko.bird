using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControladorEscena : MonoBehaviour
{
    public GameObject canvasPerdiste;
    public GameObject GameOverSound;
    // Start is called before the first frame update

    void Start()
    {
        Time.timeScale = 1;
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perdiste()
    {
        canvasPerdiste.SetActive(true);
        Time.timeScale = 0;
        Instantiate(GameOverSound);
    }


    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void RegresarMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    //Intento de reiniio con tecla R en PC.
    //public void Reiniciar2()
    //{
      //  if (Input.GetKeyDown("r"))
        //{
          //  SceneManager.LoadScene(0);
        //}
    //}
}
