using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour {
    //帮助图片
    public UISprite _helpSprite;
    //总共多少张帮助图片
    public int Count;
    //index
    private int index = 1;
    //背景面板，规则面板
    public GameObject BG, RuleBG,SkinBG;
    //向左翻页
    public void LeftClick()
    {
        if (index > 1)
            index--;
        _helpSprite.spriteName = "guide_" + index;
    }
    //向右翻页
    public void RightClick()
    {
        if (index < Count)
            index++;
        _helpSprite.spriteName = "guide_" + index;
    }
//打开规则面板
    public void OpenRule()
    {
        BG.SetActive(false);
        RuleBG.SetActive(true);
    }
    //关闭规则面板
    public void CloseRule()
    {
        BG.SetActive(true);
        RuleBG.SetActive(false);
    }
    //打开皮肤面板
    public void OpenSkin()
    {
        BG.SetActive(false);
        SkinBG.SetActive(true);
    }
    //关闭皮肤面板
    public void CloseSkin()
    {
        BG.SetActive(true);
        SkinBG.SetActive(false);
    }
    //退出游戏
    public void QuitGame()
    {
        Application.Quit();
    }
    //跳转
    public void LoadScene003()
    {
        SceneManager.LoadScene("003");
    }
}
