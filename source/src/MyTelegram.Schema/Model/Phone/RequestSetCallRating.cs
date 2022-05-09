﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
///See <a href="https://core.telegram.org/method/phone.setCallRating" />
///</summary>
[TlObject(0x59ead627)]
public sealed class RequestSetCallRating : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x59ead627;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool UserInitiative { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPhoneCall" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoneCall Peer { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }

    public void ComputeFlag()
    {
        if (UserInitiative) { Flags[0] = true; }

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        Peer.Serialize(bw);
        bw.Write(Rating);
        bw.Serialize(Comment);
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        if (Flags[0]) { UserInitiative = true; }
        Peer = br.Deserialize<MyTelegram.Schema.IInputPhoneCall>();
        Rating = br.ReadInt32();
        Comment = br.Deserialize<string>();
    }
}
