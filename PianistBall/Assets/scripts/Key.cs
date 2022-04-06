using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int keyIndex;

    Vector3 NavigationForce = new Vector3(0,80,0);
    
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

    

    private void NavigateDistance(int currentnote, int nextnote)
    {
        NavigationForce.x = ((currentnote - nextnote) ) *19.5f;
        //Debug.Log("NavigationForce  =  " + NavigationForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
          //  Debug.Log("run this shit");
            NavigateDistance(Manager.Instance.levelManager.SongIndex(currentnote), Manager.Instance.levelManager.SongIndex(currentnote + 1));
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(NavigationForce);
            Manager.Instance.audioManager.PlaySound(keyIndex);
          //  gameObject.GetComponent<Animator>().con();
           // StartCoroutine("DoAnimation");
            currentnote++;
        }
    }

     IEnumerator DoAnimation()
    {
        
        Debug.Log("before wait");
        yield return new WaitForSeconds(.5f);
        Debug.Log("after wait");
        
    }
    
}
