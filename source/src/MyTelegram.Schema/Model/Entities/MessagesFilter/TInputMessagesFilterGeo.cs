﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMessagesFilterGeo" />
///</summary>
[TlObject(0xe7026d0d)]
public class TInputMessagesFilterGeo : IMessagesFilter
{
    public uint ConstructorId => 0xe7026d0d;


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