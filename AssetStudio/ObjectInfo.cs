﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetStudio
{
    public class ObjectInfo
    {
        public long byteStart;
        public uint byteSize;
        public int typeID;
        public int classID;
        public ushort isDestroyed;
        public byte stripped;

        public long m_PathID;
        public SerializedType serializedType;

        public bool HasExportableType()
        {
            var typeID = (ClassIDType)classID;
            return typeID == ClassIDType.GameObject
                || typeID == ClassIDType.Material
                || typeID == ClassIDType.Texture2D
                || typeID == ClassIDType.Mesh
                || typeID == ClassIDType.Shader
                || typeID == ClassIDType.TextAsset
                || typeID == ClassIDType.AnimationClip
                || typeID == ClassIDType.Animator
                || typeID == ClassIDType.Font
                || (typeID == ClassIDType.AssetBundle && AssetBundle.Exportable)
                || typeID == ClassIDType.Sprite
                || (typeID == ClassIDType.MiHoYoBinData && IndexObject.Exportable)
                || (typeID == ClassIDType.IndexObject && IndexObject.Exportable);
        }
    }
}
