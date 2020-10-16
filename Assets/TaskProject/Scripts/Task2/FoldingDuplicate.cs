using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FoldingDuplicate : MonoBehaviour
{

    private float duration = 0.5f;
    

    private void Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOScaleX(-1f, duration))
            .Join(transform.DOScaleY(1f, duration))
            .Append(transform.DOScaleY(-1f, duration))
            .Append(transform.DOScaleX(1f, duration))
            .Append(transform.DOScaleY(1f, duration))
            .SetLoops(-1);
        
    }

}
