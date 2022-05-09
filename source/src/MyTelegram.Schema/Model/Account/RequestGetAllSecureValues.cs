﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getAllSecureValues" />
///</summary>
[TlObject(0xb288bc7d)]
public sealed class RequestGetAllSecureValues : IRequest<TVector<MyTelegram.Schema.ISecureValue>>
{
    public uint ConstructorId => 0xb288bc7d;

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
