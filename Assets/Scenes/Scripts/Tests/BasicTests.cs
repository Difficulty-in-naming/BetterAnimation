using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class BasicTests : MonoBehaviour,IPointerClickHandler
{
    public BetterAnimation Animation;
    public string Name;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        Animation.DoJob(Name).OnStart(_=>Debug.Log("Start")).Flip();
    }
}
