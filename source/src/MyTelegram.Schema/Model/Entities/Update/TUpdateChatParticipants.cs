﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateChatParticipants" />
///</summary>
[TlObject(0x7761198)]
public class TUpdateChatParticipants : IUpdate
{
    public uint ConstructorId => 0x7761198;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/ChatParticipants" />
    ///</summary>
    public MyTelegram.Schema.IChatParticipants Participants { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Participants.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Participants = br.Deserialize<MyTelegram.Schema.IChatParticipants>();
    }
}