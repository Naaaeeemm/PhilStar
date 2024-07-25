using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    private InputAction playerinput;

    public PlayerInput PlayerInput;

    public GameObject pauseMenu;
    public GameObject QuestScreen;

    public UnityEvent<bool> PausedOpen;

    private void Start()
    {
        playerinput = PlayerInput.actions.FindAction("Paused");
    }


    public void ToMenu()
    {

        pauseMenu.SetActive(false);
        QuestScreen.SetActive(true);

        PausedOpen.Invoke(false);

        
    }

    private void Update()
    {
        if (playerinput.IsPressed())
        {
            pauseMenu.SetActive(true);
            QuestScreen.SetActive(false);

            PausedOpen.Invoke(true);
        }
    }

    public void ToStart()
    {   
        SceneManager.LoadScene(0);                                                      
    }

}
