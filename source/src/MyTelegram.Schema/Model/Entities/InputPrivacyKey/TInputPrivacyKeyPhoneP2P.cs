﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPrivacyKeyPhoneP2P" />
///</summary>
[TlObject(0xdb9e70d2)]
public class TInputPrivacyKeyPhoneP2P : IInputPrivacyKey
{
    public uint ConstructorId => 0xdb9e70d2;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}