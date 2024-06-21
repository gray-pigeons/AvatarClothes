using UnityEngine;

namespace Metaverse
{
    /// <summary>
    /// Avatar��װ����
    /// </summary>

    [CreateAssetMenu(menuName = "Metaverse/Man001AvatarClothingConfig")]
    public class Man001AvatarClothingConfig : ScriptableObject
    {
        public ManAvatarData[] data = new ManAvatarData[0];
    }
}
