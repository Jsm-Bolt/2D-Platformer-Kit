using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Bolt;

public class PhotonToBolt : MonoBehaviourPunCallbacks
{

    public override void OnConnectedToMaster()
    {
        CustomEvent.Trigger(gameObject, "OnConnectedToMaster");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        CustomEvent.Trigger(gameObject, "OnDisconnected", cause);
    }

    public override void OnJoinedRoom()
    {
        CustomEvent.Trigger(gameObject, "OnJoinedRoom");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CustomEvent.Trigger(gameObject, "OnJoinRandomFailed", returnCode, message);
    }

}
