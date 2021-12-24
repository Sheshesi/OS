using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class GameMaster : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject playerPrefab;

    private void Awake()
    {
        var pos = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(-5f, 5f));
        PhotonNetwork.Instantiate(playerPrefab.name, pos, Quaternion.identity);

    }
    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("Player " + PhotonNetwork.NickName + " has entered the room");
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("Player " + PhotonNetwork.NickName + " has left the room");
    }
}
