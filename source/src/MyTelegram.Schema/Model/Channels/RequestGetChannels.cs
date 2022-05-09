﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.getChannels" />
///</summary>
[TlObject(0xa7f6bbb)]
public sealed class RequestGetChannels : IRequest<MyTelegram.Schema.Messages.IChats>
{
    public uint ConstructorId => 0xa7f6bbb;
    public TVector<MyTelegram.Schema.IInputChannel> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Id.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<TVector<MyTelegram.Schema.IInputChannel>>();
    }
}
