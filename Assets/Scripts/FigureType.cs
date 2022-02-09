using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigureType : ScriptableObject
    {
        public GameObject[] prefab;
        public int[] index;
    }
}