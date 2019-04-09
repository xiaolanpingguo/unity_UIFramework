using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemPanel : BasePanel
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
    }

    // 面板关闭
    // 这个页面关闭的时候，怎么做呢？
    // 在unity添加一个CanvaGroup， 然后把alpha设置为0(界面就透明了)，Blocks Raycats关闭(检测不到鼠标事件了)
    public override void OnExit()
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnClosePanel()
    {
        UIManager.Instance.PopPanel();
    }
}
