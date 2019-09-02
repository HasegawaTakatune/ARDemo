using UnityEngine;

public class ShowObject : MonoBehaviour
{
    /// <summary>
    /// オブジェクト
    /// </summary>
    [SerializeField] private GameObject gameObject;

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        GameObject.Find("Log").GetComponent<LogWindowControll>().AddText("Start " + gameObject.name + " Showtarget.");
    }

    /// <summary>
    /// オブジェクトを表示・非表示する
    /// </summary>
    public void ShowObjectTggle()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
