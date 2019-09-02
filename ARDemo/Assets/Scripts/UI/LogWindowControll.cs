using UnityEngine;
using UnityEngine.UI;

public class LogWindowControll : MonoBehaviour
{

    /// <summary>
    /// スクロールバー
    /// </summary>
    [SerializeField] private Scrollbar scrollbar;

    /// <summary>
    /// テキスト
    /// </summary>
    [SerializeField] private Text text;

    /// <summary>
    /// テキストを追加する
    /// </summary>
    /// <param name="txt">テキスト</param>
    public void AddText(string txt)
    {
        text.text += txt + "\n";
        scrollbar.value = 0;
    }
}
