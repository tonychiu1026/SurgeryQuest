/*
This file is the network manager for setting up the connection using
Photon server (a free online server) APIs.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        ConnectToServer();
    }

    // Connect to the Photon server
    void ConnectToServer()
    {
        // hook up Photon API
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Trying to connect to server...");
    }

    public override void OnConnectedToMaster() 
    {
        Debug.Log("Connected to server.");
        base.OnConnectedToMaster();
        // Hard coded some virtual room settings
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 10;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;
        // join the room
        PhotonNetwork.JoinOrCreateRoom("Room 1", roomOptions, TypedLobby.Default);
    }

    // Override the OnJoinedRoom function to display a debug log
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room.");
        base.OnJoinedRoom();
    }

    // Override the OnPlayerEnteredRoom function to display a debug log
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("A new player joined the room.");
        base.OnPlayerEnteredRoom(newPlayer);
    }
}