using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : BasePanel
{
    private CanvasGroup canvasGroup;

    void Start()
    {
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }
    }

    // 当在主界面打开一个UI的时候，主界面要被暂停，怎么做呢？
    // 这里要在unity添加一个Canvas Group组件，把射线检测关闭(Blocks Raycats)了
    public override void OnPause()
    {
        canvasGroup.blocksRaycasts = false;
    }

    // 面板恢复
    public override void OnResume()
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void PushPanel(string panelTypeString)
    {
        UIPanelType type = (UIPanelType)System.Enum.Parse(typeof(UIPanelType), panelTypeString);
        UIManager.Instance.PushPanel(type);
    }
}
