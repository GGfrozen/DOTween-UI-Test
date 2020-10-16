using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public void PlayAnimation()
    {
        var targetPosition = transform.up * 3f;
        var duration = 1f;
        var eulerAngles = new Vector3(0,180f,0);
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(targetPosition, duration))
            .Join(transform.DORotate(eulerAngles, duration))
            .AppendInterval(0.5f)
            .Append(transform.DOScale(Vector3.one * 0.75f, 0.3f))
            .Append(transform.DOScale(Vector3.one * 1.5f, 1f))
            .Join(transform.DORotate(eulerAngles, duration, RotateMode.LocalAxisAdd))
            .Append(transform.DOScale(Vector3.one, 0.2f))
            .OnComplete(OnComplete);
        
    }

    private void OnComplete()
    {
        Debug.Log("Complete !!!");
    }
}
