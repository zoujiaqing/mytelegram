﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.resetPassword" />
///</summary>
[TlObject(0x9308ce1b)]
public sealed class RequestResetPassword : IRequest<MyTelegram.Schema.Account.IResetPasswordResult>
{
    public uint ConstructorId => 0x9308ce1b;

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
