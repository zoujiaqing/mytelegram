﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
///See <a href="https://core.telegram.org/method/account.setContactSignUpNotification" />
///</summary>
[TlObject(0xcff43f61)]
public sealed class RequestSetContactSignUpNotification : IRequest<IBool>
{
    public uint ConstructorId => 0xcff43f61;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool Silent { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Silent);
    }

    public void Deserialize(BinaryReader br)
    {
        Silent = br.Deserialize<bool>();
    }
}
