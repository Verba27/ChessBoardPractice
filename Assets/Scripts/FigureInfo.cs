using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu]
    public class FigureInfo : ScriptableObject
    {
        [SerializeField] private string id;
        public GameObject prefab;
    }
}