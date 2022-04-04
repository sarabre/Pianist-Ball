using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    private char[] _Song = { 'E', 'D', 'C', 'D', 'E', 'E', 'E', 'D', 'D', 'D' };
  
    public int SongIndex(int index)
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
                    return 3;

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
