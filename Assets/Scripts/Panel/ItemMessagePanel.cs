using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemMessagePanel : BasePanel
{
    private CanvasGroup canvasGroup;

    void Start()
    {
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }
    }

    // 面板打开
    public override void OnEnter()
    {
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;

        // 动画
        transform.localScale = Vector3.zero;
        transform.DOScale(1, 0.5f);
    }

    // 面板关闭
    // 这个页面关闭的时候，怎么做呢？
    // 在unity添加一个CanvaGroup， 然后把alpha设置为0(界面就透明了)，Blocks Raycats关闭(检测不到鼠标事件了)
    public override void OnExit()
    {
        canvasGroup.blocksRaycasts = false;

        // 动画, 这里需要动画播放完毕后再设置alpha
        transform.DOScale(0, 0.5f).OnComplete(() => canvasGroup.alpha = 0);
    }

    public void OnClosePanel()
    {
        UIManager.Instance.PopPanel();
    }
}
