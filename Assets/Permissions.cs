using UnityEngine;
using UnityEngine.Android;

namespace Fologram
{
    public class Permissions : MonoBehaviour
    {
        public const string QUEST_PERMISSION_USE_SCENE = "com.oculus.permission.USE_SCENE";

        private void Start()
        {
            if (!Permission.HasUserAuthorizedPermission(QUEST_PERMISSION_USE_SCENE))
            {
                Permission.RequestUserPermission(QUEST_PERMISSION_USE_SCENE);
            }
        }
    }
}
