using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Route : MonoBehaviour
{
   [SerializeField] private Transform target;
   [SerializeField] private Transform[] points;
   
   [SerializeField] private Button playButton;
   [SerializeField] private Button stopButton;

   private Tweener tweener;
   private void Start()
   {
      playButton.onClick.AddListener(Play);
      stopButton.onClick.AddListener(Stop);
   }

   private void Play()
   {
      var path = new Vector3[points.Length];
      for (var i = 0; i < points.Length; i++)
      {
         path[i] = points[i].position;
      }

      tweener = target.DOPath(path, 5f);
   }

   private void Stop()
   {
      tweener?.Kill();
   }
}
