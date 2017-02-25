using UnityEngine;

namespace Assets
{
    public class TestMessages : MonoBehaviour
    {
        [SerializeField]
        private string log;
        [SerializeField]
        private string error;
        [SerializeField]
        private string warning;

        public void Start () {
            Debug.Log(log);
            Debug.LogError(error);
            Debug.LogWarning(warning);
        }
    }
}
