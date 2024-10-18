using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

// UI manager should have no idea what score it is now.
public class UIManager : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private Button _menuButton;
    [SerializeField] private FrameUI[] _frameUIArray;

    // Start is called before the first frame update
    void Start()
    {
        // The second way to add an event to a button.
        _menuButton.onClick.AddListener(LoadMenuScene);

        // Set up the frame numbers for each frame UI.
        for (int i = 0; i < _frameUIArray.Length; i++)
        {
            _frameUIArray[i].SetFrameNumber(i + 1);
        }

        ResetUI();
    }

    public void ResetUI()
    {
        for (int i = 0; i < _frameUIArray.Length; i++)
        {
            _frameUIArray[i].ResetAllScores();
        }
    }

    public void SetThrowScore(int frameNumber, int throwNumber, int score)
    {
        if (throwNumber == 1)
        {
            _frameUIArray[frameNumber - 1].SetFirstThrowScore(score);
        }
        else if (throwNumber == 2)
        {
            _frameUIArray[frameNumber - 1].SetSecondThrowScore(score);
        }
        else if (throwNumber == 3)
        {
            _frameUIArray[frameNumber - 1].SetThirdThrowScore(score);
        }
    }

    // To better handle the last frame
    public void SetThrowToStrike(int frameNumber, int throwNumber)
    {
        if (throwNumber == 1)
        {
            _frameUIArray[frameNumber - 1].SetFirstThrowToStrike();
        }
        else if (throwNumber == 2)
        {
            _frameUIArray[frameNumber - 1].SetSecondThrowToStrike();
        }
        else if (throwNumber == 3)
        {
            _frameUIArray[frameNumber - 1].SetThirdThrowToStrike();
        }
    }

    // To better handle the last frame
    public void SetThrowToSpare(int frameNumber, int throwNumber)
    {
        if (throwNumber == 2)
        {
            _frameUIArray[frameNumber - 1].SetSecondThrowToSpare();
        }
        else if (throwNumber == 3)
        {
            _frameUIArray[frameNumber - 1].SetThirdThrowToSpare();
        }
    }

    private void LoadMenuScene()
    {
        _sceneLoader.LoadScene("Menu");
    }
}
