// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

[TlObject(0xd433ad73)]
public class TIpPort : IIpPort
{
    public uint ConstructorId => 0xd433ad73;
    public int Ipv4 { get; set; }
    public int Port { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Ipv4);
        bw.Write(Port);
    }

    public void Deserialize(BinaryReader br)
    {
        Ipv4 = br.ReadInt32();
        Port = br.ReadInt32();
    }
}