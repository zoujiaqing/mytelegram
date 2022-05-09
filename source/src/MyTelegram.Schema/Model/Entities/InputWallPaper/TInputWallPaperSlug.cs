﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputWallPaperSlug" />
///</summary>
[TlObject(0x72091c80)]
public class TInputWallPaperSlug : IInputWallPaper
{
    public uint ConstructorId => 0x72091c80;
    public string Slug { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Slug);
    }

    public void Deserialize(BinaryReader br)
    {
        Slug = br.Deserialize<string>();
    }
}