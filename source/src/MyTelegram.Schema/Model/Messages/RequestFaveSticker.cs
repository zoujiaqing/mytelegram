﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.faveSticker" />
///</summary>
[TlObject(0xb9ffc55b)]
public sealed class RequestFaveSticker : IRequest<IBool>
{
    public uint ConstructorId => 0xb9ffc55b;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputDocument" />
    ///</summary>
    public MyTelegram.Schema.IInputDocument Id { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool Unfave { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Id.Serialize(bw);
        bw.Serialize(Unfave);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<MyTelegram.Schema.IInputDocument>();
        Unfave = br.Deserialize<bool>();
    }
}
