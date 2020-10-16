using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UseCards : MonoBehaviour
{
    private void OnMouseEnter()
    {
        var sequence = DOTween.Sequence();
        var transformPosition = transform.position;
        transformPosition.x += 1f;
        transform.position = transformPosition;
    }

    private void Update()
    {
        OnMouseEnter();
    }
}
