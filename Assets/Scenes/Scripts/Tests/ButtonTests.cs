using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTests : MonoBehaviour,IPointerEnterHandler,IPointerDownHandler,IPointerExitHandler
{
    private BetterAnimation mBetterAnimation;
    private AnimationBuilder NormalAnimation;
    private AnimationBuilder HoverAnimation;
    void Start()
    {
        mBetterAnimation = GetComponent<BetterAnimation>();
        NormalAnimation = mBetterAnimation.Build("ButtonNormal").SetLoops(-1).PlayForward();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        NormalAnimation.Kill();
        HoverAnimation = mBetterAnimation.Build("ButtonHighlighted").PlayForward();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        NormalAnimation.Kill();
        HoverAnimation.Kill();
        mBetterAnimation.Build("ButtonPressed").PlayForward();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverAnimation.Kill();
        NormalAnimation = mBetterAnimation.Build("ButtonNormal").SetLoops(-1).PlayForward();
    }
}
