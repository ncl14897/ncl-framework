using UnityEngine;

namespace NCL.Framework
{
    public class UIPopupRootSetter : MonoBehaviour
    {
        void Awake()
        {
            UIPopupHelper.popupRoot = transform;
        }
    }
}