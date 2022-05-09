﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xb5890dba)]
public class TServerDHInnerData : IObject
{
    public uint ConstructorId => 0xb5890dba;
    public byte[] Nonce { get; set; }
    public byte[] ServerNonce { get; set; }
    public int G { get; set; }
    public byte[] DhPrime { get; set; }
    public byte[] GA { get; set; }
    public int ServerTime { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        SerializerFactory.CreateInt128Serializer().Serialize(Nonce, bw);
        SerializerFactory.CreateInt128Serializer().Serialize(ServerNonce, bw);
        bw.Write(G);
        bw.Serialize(DhPrime);
        bw.Serialize(GA);
        bw.Write(ServerTime);
    }

    public void Deserialize(BinaryReader br)
    {
        Nonce = SerializerFactory.CreateInt128Serializer().Deserialize(br);
        ServerNonce = SerializerFactory.CreateInt128Serializer().Deserialize(br);
        G = br.ReadInt32();
        DhPrime = br.Deserialize<byte[]>();
        GA = br.Deserialize<byte[]>();
        ServerTime = br.ReadInt32();
    }
}