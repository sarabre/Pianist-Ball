using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
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
        NavigationForce.x = ((currentnote - nextnote) ) *20;
        Debug.Log("NavigationForce  =  " + NavigationForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            Debug.Log("run this sheet");
            NavigateDistance(Manager.Instance.levelManager.SongIndex(currentnote), Manager.Instance.levelManager.SongIndex(currentnote + 1));
            collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(NavigationForce);
            
            currentnote++;
        }
    }

    
}
