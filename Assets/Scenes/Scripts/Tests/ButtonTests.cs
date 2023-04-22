using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTests : MonoBehaviour,IPointerEnterHandler,IPointerDownHandler,IPointerExitHandler,IPointerUpHandler
{
    private BetterAnimation mBetterAnimation;
    private AnimationBuilder NormalAnimation;
    private AnimationBuilder HoverAnimation;
    void Start()
    {
        mBetterAnimation = GetComponent<BetterAnimation>();
        NormalAnimation = mBetterAnimation.DoJob("ButtonNormal").SetLoops(-1);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        NormalAnimation.Kill();
        HoverAnimation = mBetterAnimation.DoJob("ButtonHighlighted");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        NormalAnimation.Kill();
        HoverAnimation.Kill();
        mBetterAnimation.DoJob("ButtonPressed");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverAnimation.Kill();
        NormalAnimation = mBetterAnimation.DoJob("ButtonNormal").SetLoops(-1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mBetterAnimation.DoJob("ButtonPressed").Flip();
    }
}
