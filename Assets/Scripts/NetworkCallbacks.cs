using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    public override void SceneLoadLocalDone(string scene)
    {
        BoltNetwork.Instantiate(BoltPrefabs.CustomCube, new Vector3 (Random.Range (-8, 8), 0.0f, Random.Range (-8, 8)), Quaternion.identity);
    }
}
