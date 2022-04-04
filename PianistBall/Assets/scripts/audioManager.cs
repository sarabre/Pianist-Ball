using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
   [SerializeField] AudioSource[] Sound ;
  
    

    public void PlaySound(int index)
    {
       Sound[Manager.Instance.levelManager.SongIndex(index)].Play();
    }

    
}
