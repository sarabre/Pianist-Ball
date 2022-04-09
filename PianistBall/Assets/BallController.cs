using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BallController : MonoBehaviour
{

    public Transform[] PositionForKeys;
    private float JumpDelay = 1f;
    private float JumpPower = 0.3f;

    private int currentnote
    {
        get
        {
            return Manager.Instance.levelManager.playindex;
        }
        set
        {
            Manager.Instance.levelManager.playindex = value;
        }

    }

    private Vector3 PosKey;
    private Vector3 PosKeyFinall
    {
        get
        {
            PosKey = PositionForKeys[Manager.Instance.levelManager.SongIndex(currentnote)].position;
            PosKey.z -= 0.3f;
            return PosKey;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("key"))
        {
            try 
            {
                NextJump();
            }
            catch
            {
                return;
            }
            
        }
    }

    public void NextJump()
    {
        transform.DOLocalJump(PosKeyFinall,JumpPower,1, JumpDelay, false);
        currentnote++;
    }
}
