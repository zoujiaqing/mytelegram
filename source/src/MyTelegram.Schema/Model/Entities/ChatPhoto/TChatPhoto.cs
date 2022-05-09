﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/chatPhoto" />
///</summary>
[TlObject(0x1c6e1c11)]
public class TChatPhoto : IChatPhoto
{
    public uint ConstructorId => 0x1c6e1c11;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool HasVideo { get; set; }
    public long PhotoId { get; set; }
    public byte[]? StrippedThumb { get; set; }
    public int DcId { get; set; }

    public void ComputeFlag()
    {
        if (HasVideo) { Flags[0] = true; }
        if (StrippedThumb != null) { Flags[1] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        bw.Write(PhotoId);
        if (Flags[1]) { bw.Serialize(StrippedThumb); }
        bw.Write(DcId);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { HasVideo = true; }
        PhotoId = br.ReadInt64();
        if (Flags[1]) { StrippedThumb = br.Deserialize<byte[]>(); }
        DcId = br.ReadInt32();
    }
}