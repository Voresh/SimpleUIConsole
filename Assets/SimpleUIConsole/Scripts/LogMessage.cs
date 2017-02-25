using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class LogMessage : MonoBehaviour
    {
        [SerializeField]
        private Image icon;
        [SerializeField]
        private Text message;
        [SerializeField]
        private Text stackTrace;

        public void SetIcon(Sprite icon)
        {
            this.icon.sprite = icon;
        }

        public void SetMessage(string message)
        {
            this.message.text = message;
        }

        public void SetStackTrace(string stackTrace)
        {
            this.stackTrace.text = stackTrace;
        }
    }
}