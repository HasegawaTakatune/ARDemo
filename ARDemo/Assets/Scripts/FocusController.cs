using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class FocusController : MonoBehaviour
{
    /// <summary>
    /// フォーカス開始判定
    /// </summary>
    private bool vuforiaStarted = false;

    /// <summary>
    /// 初期化
    /// </summary>
    void Start()
    {
        // インスタンス取得できたら、Vuforiaスタートコールバックを設定
        VuforiaARController vuforia = VuforiaARController.Instance;
        if (vuforia != null)
            vuforia.RegisterVuforiaStartedCallback(StartAfterVuforia);
    }

    /// <summary>
    /// マーカー読み込みが始まるとカメラをオートフォーカスに設定する
    /// </summary>
    private void StartAfterVuforia()
    {
        vuforiaStarted = true;
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    /// <summary>
    /// アプリがポーズに入るとオートフォーカスを解除する
    /// </summary>
    /// <param name="pause"></param>
    void OnApplicationPause(bool pause)
    {
        if (!pause && vuforiaStarted)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
}