﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;


///<summary>
///See <a href="https://core.telegram.org/constructor/messages.messagesNotModified" />
///</summary>
[TlObject(0x74535f21)]
public class TMessagesNotModified : IMessages
{
    public uint ConstructorId => 0x74535f21;
    public int Count { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Count);
    }

    public void Deserialize(BinaryReader br)
    {
        Count = br.ReadInt32();
    }
}