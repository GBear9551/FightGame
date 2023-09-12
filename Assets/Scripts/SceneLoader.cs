using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Go to Main Menu
    public void GoToMainMenu()
    {

        SceneManager.LoadScene("MainMenu");

    }

    // Go to Mode Selection Screen
    public void GoToModeSelectionScreen()
    {

        SceneManager.LoadScene("ModeSelectionScreen");
    }

    // Go to Stage Selection Screen
    public void GoToStageSelectionScreen()
    {

        SceneManager.LoadScene("StageSelectionScreen");
    }

    // Go to Character Selection Screen
    void GoToCharacterSelectionScreen()
    {

        SceneManager.LoadScene("CharacterSelectionScreen");
    }

    // Go to Castle Stage
    void GoToCastleStage()
    {
        SceneManager.LoadScene("CastleStage");
    }


    // Go to Amazing Galaxy Stage




}
