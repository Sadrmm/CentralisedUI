using UnityEngine;
using UnityEngine.UI;

namespace ProgramadorCastellano.CentralisedUI
{
    [CreateAssetMenu(menuName = "ProgramadorCastellano/CentralisedUI/Animation", order = 3)]
    public class CentralisedUIAnimationSO : ScriptableObject
    {
        [SerializeField] AnimationTriggers _animations;
        public AnimationTriggers Animations => _animations;
    }
}
