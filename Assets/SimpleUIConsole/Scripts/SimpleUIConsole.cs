using UnityEditor;
using UnityEngine;

namespace Assets
{
    public class SimpleUIConsole : MonoBehaviour {
        [SerializeField]
        private Transform messagesParent;
        [SerializeField]
        private GameObject logMessagePrefab;

        private Sprite errorSprite;
        private Sprite messageSprite;
        private Sprite warningSprite;

        public void Awake()
        {
            Application.logMessageReceived += HandleLog;

            errorSprite =  GetSpriteFromTexture(EditorGUIUtility.FindTexture("console.erroricon"));
            messageSprite =  GetSpriteFromTexture(EditorGUIUtility.FindTexture("console.infoicon"));
            warningSprite =  GetSpriteFromTexture(EditorGUIUtility.FindTexture("console.warnicon"));
        }

        private Sprite GetSpriteFromTexture(Texture2D texture)
        {
            return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }

        public void HandleLog(string logString, string stackTrace, LogType type)
        {
            LogMessage tmp = Instantiate(logMessagePrefab).GetComponent<LogMessage>();
            switch (type)
            {
                case LogType.Error:
                    tmp.SetIcon(errorSprite);
                    break;
                case LogType.Exception:
                    tmp.SetIcon(errorSprite);
                    break;
                case LogType.Warning:
                    tmp.SetIcon(warningSprite);
                    break;
                default:
                    tmp.SetIcon(messageSprite);
                    break;
            }
            tmp.SetMessage(logString);
            tmp.SetStackTrace(stackTrace);
            tmp.transform.SetParent(messagesParent, false);
        }
    }
}
