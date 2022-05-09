﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.featuredStickersNotModified" />
///</summary>
[TlObject(0xc6dc0c66)]
public class TFeaturedStickersNotModified : IFeaturedStickers
{
    public uint ConstructorId => 0xc6dc0c66;
    public int Count { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Count);
    }

    public void Deserialize(BinaryReader br)
    {
        Count = br.ReadInt32();
    }
}