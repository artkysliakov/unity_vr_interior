using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToPosition : MonoBehaviour {

public void MovePlayer()
    {
        Player.SetPosition(transform.position);
        //gameObject.SetActive(false);
    }
}
