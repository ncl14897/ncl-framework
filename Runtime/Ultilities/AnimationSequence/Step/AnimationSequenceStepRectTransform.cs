using Sirenix.OdinInspector;
using UnityEngine;

namespace NCL.Framework
{
    public class AnimationSequenceStepRectTransform : AnimationSequenceStepAction<RectTransform>
    {
        [SerializeField]
        [HorizontalGroup("Target"), ShowIf("@_isUseTarget == false")]
        [InlineButton("@_isUseTarget = true", Label = "Value")]
        protected Vector3 _value;
    }
}