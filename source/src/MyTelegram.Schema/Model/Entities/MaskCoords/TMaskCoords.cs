﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/maskCoords" />
///</summary>
[TlObject(0xaed6dbb2)]
public class TMaskCoords : IMaskCoords
{
    public uint ConstructorId => 0xaed6dbb2;
    public int N { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Zoom { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(N);
        bw.Serialize(X);
        bw.Serialize(Y);
        bw.Serialize(Zoom);
    }

    public void Deserialize(BinaryReader br)
    {
        N = br.ReadInt32();
        X = br.ReadDouble();
        Y = br.ReadDouble();
        Zoom = br.ReadDouble();
    }
}