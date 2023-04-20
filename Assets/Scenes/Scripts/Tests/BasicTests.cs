using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestAnimation : MonoBehaviour,IPointerClickHandler
{
    public BetterAnimation Animation;
    public string Name;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        Animation.Build(Name).OnStart(_=>Debug.Log("Start")).Sequence.SetInverted().Play();
    }
}
