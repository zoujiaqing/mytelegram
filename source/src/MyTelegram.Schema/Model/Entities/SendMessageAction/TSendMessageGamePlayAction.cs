﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/sendMessageGamePlayAction" />
///</summary>
[TlObject(0xdd6a8f48)]
public class TSendMessageGamePlayAction : ISendMessageAction
{
    public uint ConstructorId => 0xdd6a8f48;


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