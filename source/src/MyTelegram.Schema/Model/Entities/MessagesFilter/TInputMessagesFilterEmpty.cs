﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMessagesFilterEmpty" />
///</summary>
[TlObject(0x57e2f66c)]
public class TInputMessagesFilterEmpty : IMessagesFilter,IEmpty
{
    public uint ConstructorId => 0x57e2f66c;


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