using System;
using UnityEngine;

namespace Metaverse
{
    /// <summary>
    /// Avatar�������
    /// </summary>
    [Serializable]
    public class AvatarOutlookData
    {
        /// <summary>
        /// ͷ������
        /// </summary>
        public Mesh headMesh;
        /// <summary>
        /// ͷ������
        /// </summary>
        public Material headMaterial;

        /// <summary>
        /// ��������
        /// </summary>
        public Mesh bodyMesh;
        /// <summary>
        /// �������
        /// </summary>
        public Material bodyMaterial;

        /// <summary>
        /// ��������
        /// </summary>
        public Mesh topMesh;
        /// <summary>
        /// ���²���
        /// </summary>
        public Material topMaterial;

        /// <summary>
        /// ��������
        /// </summary>
        public Mesh bottomMesh;
        /// <summary>
        /// ���Ӳ���
        /// </summary>
        public Material bottomMaterial;

        /// <summary>
        /// Ь������
        /// </summary>
        public Mesh footwearMesh;
        /// <summary>
        /// Ь�Ӳ���
        /// </summary>
        public Material footwearMaterial;

        /// <summary>
        /// ����ͼ
        /// </summary>
        public Sprite thumb;
    }

    [Serializable]
    public class ManAvatarData
    {
        public Mesh eayLeftMesh;

        public Material eayLeftMaterial;

        public Mesh eayRightMesh;

        public Material eayRightMaterial;

        public Mesh wolf3DBodyMesh;

        public Material wolf3DBodyMaterial;

        public Mesh wolf3DGlassesMesh;

        public Material wolf3DGlassesMaterial;

        public Mesh wolf3DHairMesh;

        public Material wolf3DHairMaterial;

        public Mesh wolf3DHeadMesh;

        public Material wolf3DHeadMaterial;

        public Mesh wolf3DOutfitBottomMesh;

        public Material wolf3DOutfitBottomMaterial;
        public Mesh wolf3DOutfitFootwearMesh;

        public Material wolf3DOutfitFootwearMaterial;
        public Mesh wolf3DOutfitTopMesh;

        public Material wolf3DOutfitTopMaterial;
        public Mesh wolf3DOutfitTeethMesh;

        public Material wolf3DOutfitTeethMaterial;



    }
}
