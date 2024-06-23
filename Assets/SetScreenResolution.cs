using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScreenResolution : MonoBehaviour
{
    // 設定你想要的解析度
    public int width = 800;
    public int height = 600;

    void Start()
    {
        SetFixedResolution();
    }

    void SetFixedResolution()
    {
        Screen.SetResolution(width, height, true);
    }
}
