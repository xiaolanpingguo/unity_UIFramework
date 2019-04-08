using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;



public class UIManager : MonoBehaviour
{
    private Dictionary<UIPanelType, string> panelPathDict;  // 存储所有面板Prefab的路径
    private Dictionary<UIPanelType, BasePanel> panelDict;   // 保存所有实例化面板的游戏物体身上的BasePanel组件

    private Transform canvasTransform;
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new UIManager();
            }
            return _instance;
        }
    }

    private Transform CanvasTransform
    {
        get
        {
            if (canvasTransform == null)
            {
                canvasTransform = GameObject.Find("Canvas").transform;
            }
            return canvasTransform;
        }
    }

    private UIManager()
    {
        ParseUIPanelTypeJson();
    }

    // 得到一个面板
    private BasePanel GetPanel(UIPanelType panelType)
    {
        if (panelDict == null)
        {
            panelDict = new Dictionary<UIPanelType, BasePanel>();
        }

        //BasePanel panel;
        //panelDict.TryGetValue(panelType, out panel);//TODO

        //BasePanel panel = panelDict.TryGet(panelType);
        //if (panel == null)
        //{
        //    //如果找不到，那么就找这个面板的prefab的路径，然后去根据prefab去实例化面板
        //    //string path;
        //    //panelPathDict.TryGetValue(panelType, out path);
        //    string path = panelPathDict.TryGet(panelType);
        //    GameObject instPanel = GameObject.Instantiate(Resources.Load(path)) as GameObject;
        //    instPanel.transform.SetParent(CanvasTransform, false);
        //    panelDict.Add(panelType, instPanel.GetComponent<BasePanel>());
        //    return instPanel.GetComponent<BasePanel>();
        //}
        //else
        //{
        //    return panel;
        //}
    }

    private void ParseUIPanelTypeJson()
    {
        panelPathDict = new Dictionary<UIPanelType, string>();

        TextAsset ta = Resources.Load<TextAsset>("UIPanelType");

        //UIPanelTypeJson jsonObject = JsonUtility.FromJson<UIPanelTypeJson>(ta.text);

        //foreach (UIPanelInfo info in jsonObject.infoList)
        //{
        //    //Debug.Log(info.panelType);
        //    panelPathDict.Add(info.panelType, info.path);
        //}
    }
}
