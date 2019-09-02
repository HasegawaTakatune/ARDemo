using UnityEngine;

public class ChangeActive : MonoBehaviour
{

    /// <summary>
    /// オブジェクト１
    /// </summary>
    [SerializeField] private GameObject object1;

    /// <summary>
    /// オブジェクト２
    /// </summary>
    [SerializeField] private GameObject object2;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        object1.SetActive(true);
        object2.SetActive(false);
    }

    /// <summary>
    /// チェンジボタンクリックイベント
    /// </summary>
    public void OnClickChangeButton()
    {
        object1.SetActive(!object1.activeInHierarchy);
        object2.SetActive(!object2.activeInHierarchy);
    }
}
