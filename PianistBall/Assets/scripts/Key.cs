using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Key : MonoBehaviour
{
    public int keyIndex;

    private float DelayForAnimation = 0.25f;
    private float YKeyDown = 0.5f;
    private float YKey = 0.6f;

    

    
    private int currentnote
    {
        get
        {
            return Manager.Instance.levelManager.playindex;
        }
    }

    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            try
            {
                Manager.Instance.audioManager.PlaySound(Manager.Instance.levelManager.SongIndex(currentnote));
                StartCoroutine("DoAnimation");
                


            }
            catch
            {
                return;
            }
    }
    }

     IEnumerator DoAnimation()
    {
        transform.DOLocalMoveY(YKeyDown, DelayForAnimation);
        yield return new WaitForSeconds(DelayForAnimation);
        transform.DOLocalMoveY(YKey, DelayForAnimation);
    }

}
