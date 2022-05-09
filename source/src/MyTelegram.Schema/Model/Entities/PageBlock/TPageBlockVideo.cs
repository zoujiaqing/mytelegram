﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/pageBlockVideo" />
///</summary>
[TlObject(0x7c8fe7b6)]
public class TPageBlockVideo : IPageBlock
{
    public uint ConstructorId => 0x7c8fe7b6;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Autoplay { get; set; }
    public bool Loop { get; set; }
    public long VideoId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PageCaption" />
    ///</summary>
    public MyTelegram.Schema.IPageCaption Caption { get; set; }

    public void ComputeFlag()
    {
        if (Autoplay) { Flags[0] = true; }
        if (Loop) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(VideoId);
        Caption.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Autoplay = true; }
        if (Flags[1]) { Loop = true; }
        VideoId = br.ReadInt64();
        Caption = br.Deserialize<MyTelegram.Schema.IPageCaption>();
    }
}