using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    //public GameObject menuPanel;
    private bool isPaused = false;
    private float previousTimeScale;
    private GameObject[] pauseObjects;
    [SerializeField] TMP_Text pauseText;

    private void Start()
    {
        pauseText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Change to your desired input key
        {
            if (!isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Freezes the game
        isPaused = true;
        pauseText.gameObject.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Restore the previous time scale
        isPaused = false;
        pauseText.gameObject.SetActive(false);
    }

    // Called from a Resume button in the menu
    public void OnResumeButtonClicked()
    {
        ResumeGame();
    }
}
