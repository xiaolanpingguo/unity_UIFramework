using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KnapsackPanel : BasePanel
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

        // 动画，从右边移动过来
        Vector3 tmp = transform.localPosition;
        tmp.x = 600;
        transform.localPosition = tmp;
        transform.DOLocalMoveX(0, 0.5f);
    }

    // 面板关闭
    // 这个页面关闭的时候，怎么做呢？
    // 在unity添加一个CanvaGroup， 然后把alpha设置为0(界面就透明了)，Blocks Raycats关闭(检测不到鼠标事件了)
    public override void OnExit()
    {    
        canvasGroup.blocksRaycasts = false;

        // 动画
        transform.DOLocalMoveX(600, 0.5f).OnComplete(()=> canvasGroup.alpha = 0);
    }

    // 面板暂停
    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
    }

    // 面板恢复
    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnClosePanel()
    {
        UIManager.Instance.PopPanel();
    }

    // 物品信息详情的面板
    public void OnItemButtonClick()
    {
        UIManager.Instance.PushPanel(UIPanelType.ItemMessage);
    }
}
