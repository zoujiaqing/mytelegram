﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/channelParticipantSelf" />
///</summary>
[TlObject(0x28a8bc67)]
public class TChannelParticipantSelf : IChannelParticipant
{
    public uint ConstructorId => 0x28a8bc67;
    public long UserId { get; set; }
    public long InviterId { get; set; }
    public int Date { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        bw.Write(InviterId);
        bw.Write(Date);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        InviterId = br.ReadInt64();
        Date = br.ReadInt32();
    }
}