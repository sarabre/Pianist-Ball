using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    private char[] _Song = { 'E', 'D', 'C', 'D', 'E', 'E', 'E', 'D', 'D', 'D', 'E', 'G', 'G', 'E', 'D', 'C', 'D', 'E', 'E', 'E', 'E', 'D', 'D', 'E', 'D','C' };


    #region property for ball

    [SerializeField] private GameObject Ball;

    private Transform BallTra;
    public Transform balltra
    {
        get
        {
            if (BallTra == null)
                BallTra = Ball.transform;
            return BallTra;
        }

    }

    private Rigidbody BallRig ;
    public Rigidbody ballrig
    {
        get
        {
            if (BallRig == null)
                BallRig = Ball.GetComponent<Rigidbody>();
            return BallRig;
        }

    }

    #endregion

    public int SongIndex(int index) // Method returns note based on the index of letter array 
    {
        

        switch (_Song[index])
         {
              case 'C':
                    return 0;

                case 'D':
                    return 1;

                case 'E':
                    return 2;

                case 'G':
                    return 4;

                default:
                    return 0;
         }
        
    }

    

    private int _PlayIndex = 0;
    public int playindex
    {
        get
        {
            return _PlayIndex;
        }
        set
        {
            if (value == _PlayIndex + 1)
                _PlayIndex++;
        }
    }
}
