﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/messageEntityEmail" />
///</summary>
[TlObject(0x64e475c2)]
public class TMessageEntityEmail : IMessageEntity
{
    public uint ConstructorId => 0x64e475c2;
    public int Offset { get; set; }
    public int Length { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Offset);
        bw.Write(Length);
    }

    public void Deserialize(BinaryReader br)
    {
        Offset = br.ReadInt32();
        Length = br.ReadInt32();
    }
}