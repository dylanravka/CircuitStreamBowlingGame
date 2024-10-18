using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _frameNumber;
    [SerializeField] private TMP_Text _firstThrowScore;
    [SerializeField] private TMP_Text _secondThrowScore;
    [SerializeField] private TMP_Text _thirdThrowScore;
    [SerializeField] private TMP_Text _totalScore;

    [SerializeField] private bool _isLastFrame;

    public void SetFrameNumber(int num)
    {
        _frameNumber.text = num.ToString();
    }

    public void ResetAllScores()
    {
        _firstThrowScore.text = string.Empty;
        _secondThrowScore.text = string.Empty;

        if (_isLastFrame)
        {
            _thirdThrowScore.text = string.Empty;
        }

        // Check if the third throw score has been assigned.
        //if (_thirdThrowScore != null)
        //{
        //    _thirdThrowScore.text = string.Empty;
        //}

        _totalScore.text = string.Empty;
    }

    public void SetFirstThrowScore(int score)
    {
        _firstThrowScore.text = score.ToString();
    }

    public void SetSecondThrowScore(int score)
    {
        _secondThrowScore.text = score.ToString();
    }

    public void SetThirdThrowScore(int score)
    {
        if (_isLastFrame)
        {
            _thirdThrowScore.text = score.ToString();
        }
    }

    // Ready for the last frame
    public void SetFirstThrowToStrike()
    {
        _firstThrowScore.text = "X";
    }

    public void SetSecondThrowToStrike()
    {
        _secondThrowScore.text = "X";
    }

    public void SetThirdThrowToStrike()
    {
        if (_isLastFrame)
        {
            _thirdThrowScore.text = "X";
        }
    }

    public void SetSecondThrowToSpare()
    {
        _secondThrowScore.text = "/";
    }

    public void SetThirdThrowToSpare()
    {
        if (_isLastFrame)
        {
            _thirdThrowScore.text = "/";
        }
    }

    public void SetTotalScore(int score)
    {
        _totalScore.text = score.ToString();
    }
}
