using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLineTrace : MonoBehaviour
{
    /// <summary>
    /// ターゲット名
    /// </summary>
    [SerializeField] private Text targetName;

    /// <summary>
    /// 照準
    /// </summary>
    [SerializeField] private Image site;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        site.gameObject.SetActive(true);
        site.color = Color.green;
    }

    /// <summary>
    /// メインループ
    /// </summary>
    void Update()
    {
        targetName.text = string.Empty;
        
        // 当たり判定を飛ばす
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 10.0f))
        {
            // ヒットしたらターゲット名表示・照準を赤にする
            targetName.text = hit.collider.name;
            site.color = Color.red;
        }
        else site.color = Color.green;
    }

    /// <summary>
    /// 照準の表示/非表示
    /// </summary>
    public void ShowLineTraceToggle()
    {
        site.gameObject.SetActive(!site.gameObject.activeSelf);
    }
}
