﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.getAuthorizations" />
///</summary>
[TlObject(0xe320c158)]
public sealed class RequestGetAuthorizations : IRequest<MyTelegram.Schema.Account.IAuthorizations>
{
    public uint ConstructorId => 0xe320c158;

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
