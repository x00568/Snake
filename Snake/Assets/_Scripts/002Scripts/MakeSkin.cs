using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSkin : MonoBehaviour {
    public Sprite[] skin;
    public GameObject _Skin;
  

    void Awake()
    {
        int countSprite = skin.Length;
        for (int i = 0; i < countSprite; i++)
        {
            GameObject go = Instantiate(_Skin) as GameObject;
            go.transform.parent = transform;
            go.transform.localScale = Vector3.one;
            go.transform.GetComponent<UISprite>().spriteName = skin[i].name;
            go.transform.GetComponent<UIButton>().normalSprite = skin[i].name;
        }
    }
  
}
