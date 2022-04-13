using System.Collections.Generic;
using Newtonsoft.Json;
using Godot;
namespace TileCraftData
{
    public class TileData
    {
        public char CharCode;
    }
    public class BlockData : Dictionary<string, TileData>
    {
        public static readonly BlockData data = BlockData.LoadBlockData();
        private static BlockData LoadBlockData()
        {
            File fs = new File();
            fs.Open("res://Data/GameScene/Tiles/BlockData.json", File.ModeFlags.Read);
            string data = fs.GetAsText();
            BlockData obj = JsonConvert.DeserializeObject<BlockData>(data);
            return obj;
        }
    }
}