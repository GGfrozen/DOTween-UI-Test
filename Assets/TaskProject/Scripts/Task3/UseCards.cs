using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UseCards : MonoBehaviour
{
	[SerializeField] private GameObject[] cards;
	[SerializeField] private Sprite frontLabel;
	[SerializeField] float duration = 1f;
	[SerializeField] private Transform firstHandPosition;
	

	private bool isHandFull = false;

	private void Start()
	{
		MoveCardToHand();
	}
	private void MoveCardToHand()
	{
		var eulerAngles = new Vector3(0, 180f, 0);
		
		
		
		var sequence = DOTween.Sequence();
		for (var i = 0; i < cards.Length; i++)
		{
			var cardInHandPosition = firstHandPosition.position.x + i*100;
			var backImage = cards[i].GetComponent<Image>();
			sequence.Append(cards[i].transform.DOMoveX(cardInHandPosition, duration))
			
			.Join(cards[i].transform.DORotate(eulerAngles, duration)).AppendCallback(() => backImage.sprite = frontLabel);
			
		}
		
			
	}
}
