using DG.DOTweenEditor;
using DG.Tweening;

namespace NCL.Framework.Editor
{
    public static class AnimationSequenceEditor
    {
        public static void Play(Tween tween)
        {
            DOTweenEditorPreview.PrepareTweenForPreview(tween);

            DOTweenEditorPreview.Start();
        }

        public static void Stop()
        {
            DOTweenEditorPreview.Stop(true);
        }
    }
}