﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
///See <a href="https://core.telegram.org/method/help.getPromoData" />
///</summary>
[TlObject(0xc0977421)]
public sealed class RequestGetPromoData : IRequest<MyTelegram.Schema.Help.IPromoData>
{
    public uint ConstructorId => 0xc0977421;

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
