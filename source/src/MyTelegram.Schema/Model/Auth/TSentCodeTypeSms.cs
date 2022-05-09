﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Auth;


///<summary>
///See <a href="https://core.telegram.org/constructor/auth.sentCodeTypeSms" />
///</summary>
[TlObject(0xc000bba2)]
public class TSentCodeTypeSms : ISentCodeType
{
    public uint ConstructorId => 0xc000bba2;
    public int Length { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Length);
    }

    public void Deserialize(BinaryReader br)
    {
        Length = br.ReadInt32();
    }
}