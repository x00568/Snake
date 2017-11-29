using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinText : MonoBehaviour {
    
    void OnClick()
    {
        string str = GetComponent<UISprite>().spriteName;
        GameObject.Find("ShopBg/Label/Label").GetComponent<UILabel>().text = str;
    }
}
