using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLineTrace : MonoBehaviour
{

    [SerializeField] private LogWindowControll log;

    [SerializeField] private bool showLineTrace = true;

    [SerializeField] private Image site;

    void Start()
    {
        site.gameObject.SetActive(true);
        site.color = Color.green;
    }

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 10.0f))
        {
            log.AddText(hit.collider.name);
            site.color = Color.red;
        }
        else site.color = Color.green;
    }

    public void ShowLineTraceButton()
    {
        site.gameObject.SetActive(!site.gameObject.activeSelf);
    }

    public void ShowLineTraceToggle()
    {
        site.gameObject.SetActive(!site.gameObject.activeSelf);
    }
}
