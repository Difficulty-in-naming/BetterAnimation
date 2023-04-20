using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTests : MonoBehaviour,IPointerEnterHandler,IPointerDownHandler,IPointerExitHandler
{
    private BetterAnimation mBetterAnimation;
    void Start()
    {
        mBetterAnimation = GetComponent<BetterAnimation>();
        mBetterAnimation.Build("ButtonNormal").SetLoops(-1).PlayForward();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mBetterAnimation.Build("ButtonHighlighted").PlayForward();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mBetterAnimation.Build("ButtonPressed").PlayForward();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mBetterAnimation.Build("ButtonNormal").SetLoops(-1).PlayForward();
    }
}
