#if UNITY_EDITOR

using NCL.Framework.Editor;
using UnityEditor;

namespace NCL.Framework
{
    [CustomEditor(typeof(AnimationSequence))]
    public class AnimationSequenceInspector : Sirenix.OdinInspector.Editor.OdinEditor
    {
        protected override void OnDisable()
        {
            base.OnDisable();

            AnimationSequenceEditor.Stop();
        }
    }
}

#endif