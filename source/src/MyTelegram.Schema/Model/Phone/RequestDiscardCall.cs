﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
///See <a href="https://core.telegram.org/method/phone.discardCall" />
///</summary>
[TlObject(0xb2cbc1c0)]
public sealed class RequestDiscardCall : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xb2cbc1c0;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Video { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPhoneCall" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoneCall Peer { get; set; }
    public int Duration { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/PhoneCallDiscardReason" />
    ///</summary>
    public MyTelegram.Schema.IPhoneCallDiscardReason Reason { get; set; }
    public long ConnectionId { get; set; }

    public void ComputeFlag()
    {
        if (Video) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(Duration);
        Reason.Serialize(bw);
        bw.Write(ConnectionId);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { Video = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPhoneCall>();
        Duration = br.ReadInt32();
        Reason = br.Deserialize<MyTelegram.Schema.IPhoneCallDiscardReason>();
        ConnectionId = br.ReadInt64();
    }
}
