﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputUserSelf" />
///</summary>
[TlObject(0xf7c1b13f)]
public class TInputUserSelf : IInputUser
{
    public uint ConstructorId => 0xf7c1b13f;


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