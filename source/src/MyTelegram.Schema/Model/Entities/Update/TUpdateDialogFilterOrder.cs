﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/updateDialogFilterOrder" />
///</summary>
[TlObject(0xa5d72105)]
public class TUpdateDialogFilterOrder : IUpdate
{
    public uint ConstructorId => 0xa5d72105;
    public TVector<int> Order { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Order.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Order = br.Deserialize<TVector<int>>();
    }
}