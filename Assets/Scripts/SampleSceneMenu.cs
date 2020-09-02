using Bolt.Matchmaking;
using System;
using System.Collections;
using System.Collections.Generic;
using UdpKit;
using UnityEngine;

public class SampleSceneMenu : Bolt.GlobalEventListener
{
    public void StartServer()
    {
        BoltLauncher.StartServer();
    }

    public void StartClient()
    {
        BoltLauncher.StartClient();
    }

    public override void BoltStartDone()
    {
        if (BoltNetwork.IsServer)
        {
            //BoltMatchmaking.CreateSession(Guid.NewGuid().ToString(), null, "SampleScene");

            BoltMatchmaking.CreateSession(
                sessionID: "Jocasta",
                sceneToLoad: "SampleScene"
            );
        }
    }

    public override void SessionListUpdated(Map<Guid, UdpSession> sessionList)
    {
        foreach (var session in sessionList)
        {
            UdpSession photonSession = session.Value;

            if (photonSession.Source == UdpSessionSource.Photon)
            {
                
                BoltMatchmaking.JoinSession(photonSession);
            }
        }
    }
}
