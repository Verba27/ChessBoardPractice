using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigureType : ScriptableObject
    {
        public FigureInfo figureInfos;
        public Material[] figMaterial;
        public int[] index;
    }
}