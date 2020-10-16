using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button stopButton;

    private void Start()
    {
        startButton.onClick.AddListener(animateStartButton);
        stopButton.onClick.AddListener(animateStopButton);
    }

    private void animateStartButton()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(startButton.transform.DOScale(Vector3.one * 2f, 1f))
            .Append(startButton.transform.DOShakeScale(1f, 1f, 20, 30f))
            .AppendInterval(0.5f)
            .Append(startButton.transform.DOScale(Vector3.one, 1f));
    }

    private void animateStopButton()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(stopButton.transform.DORotate(new Vector3(0, 0, 180), 1f))
            .Append(stopButton.image.DOColor(Color.blue, 0.5f))
            .AppendInterval(0.5f)
            .Append(stopButton.image.DOColor(Color.red, 0.5f))
            .Append(stopButton.transform.DORotate(new Vector3(0, 0, 0), 1f));
    }
}
