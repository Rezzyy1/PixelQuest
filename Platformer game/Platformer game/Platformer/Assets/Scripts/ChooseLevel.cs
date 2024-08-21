using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseLevel : MonoBehaviour
{
    [SerializeField] private GameObject ChooseGame;
    [SerializeField] private GameObject PausePanel;

    public void PlayButtonPressed()
    {
        ChooseGame.SetActive(true);
        PausePanel.SetActive(false);

    }

    public void ReturnButtonPressed()
    {
        ChooseGame.SetActive(false);
        PausePanel.SetActive(true);
    }
}

