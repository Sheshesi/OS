using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private SettingsPopUp window;
    [SerializeField] private TMPro.TextMeshProUGUI nickName;

    private void Awake()
    {
        nickName.text = PhotonNetwork.NickName;
    }
    public void DoShowWindow()
    {
        window.gameObject.SetActive(true);
        window.Show();
    }
}
