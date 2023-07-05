using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject MenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        //ativando painel do menu
        MenuPanel.SetActive(true); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //função botaum start
    public void StartGame()
    {
        SceneManager.LoadScene(nomeCena);
    }
}
