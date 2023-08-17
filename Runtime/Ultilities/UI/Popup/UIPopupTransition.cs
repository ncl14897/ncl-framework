using DG.Tweening;
using UnityEngine;

namespace NCL.Framework
{
    public abstract class UIPopupTransition : MonoBehaviour
    {
        public abstract Tween ConstructTransition(UIPopupBehaviour popup);
    }
}