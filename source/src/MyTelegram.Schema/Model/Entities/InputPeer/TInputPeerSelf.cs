﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPeerSelf" />
///</summary>
[TlObject(0x7da07ec9)]
public class TInputPeerSelf : IInputPeer
{
    public uint ConstructorId => 0x7da07ec9;


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