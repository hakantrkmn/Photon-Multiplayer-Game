using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PhotonLauncher : MonoBehaviourPunCallbacks
{
    public override void OnEnable()
    {
        base.OnEnable();
        EventManager.CreateRoomButtonClicked += CreateRoom;
        EventManager.LeaveRoomButtonCliced += LeaveRoom;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        EventManager.LeaveRoomButtonCliced -= LeaveRoom;
        EventManager.CreateRoomButtonClicked -= CreateRoom;
    }

    void Start()
    {
        Debug.Log("Connecting to Master");
        EventManager.OpenMenu(MenuTypes.LoadingMenu);
        PhotonNetwork.ConnectUsingSettings();
    }
    
    

    
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        EventManager.OpenMenu(MenuTypes.TitleMenu);

        Debug.Log("Joined Lobby");
    }


    public void CreateRoom(string roomName)
    {
        Debug.Log("create room");

        PhotonNetwork.CreateRoom(roomName);
        EventManager.OpenMenu(MenuTypes.LoadingMenu);

    }

    public override void OnJoinedRoom()
    {
        Debug.Log("joined room");

        EventManager.OpenMenu(MenuTypes.RoomMenu);

    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("room failed");
        EventManager.OpenMenu(MenuTypes.ErrorMenu);
        EventManager.RoomFailed(message);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        EventManager.OpenMenu(MenuTypes.LoadingMenu);
    }

    public override void OnLeftRoom()
    {
        EventManager.OpenMenu(MenuTypes.TitleMenu);

    }
}
