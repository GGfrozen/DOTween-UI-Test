using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CircleQuarterRotation : MonoBehaviour
{
    [SerializeField] private Transform circle1;
    [SerializeField] private Transform circle2;

    private void Start()
    {
        CircleRotate();
    }

    private void CircleRotate()
    {
        var duration = 1f;
        var eulerAngles = new Vector3(0,0,360f);
        var sequence = DOTween.Sequence();
        sequence.Append(circle1.DORotate(eulerAngles, duration, RotateMode.FastBeyond360).SetEase(Ease.Linear))
            .Join(circle2.DORotate(-eulerAngles, duration, RotateMode.FastBeyond360).SetEase(Ease.Linear))
            .SetLoops(-1, LoopType.Restart);
    }
}
