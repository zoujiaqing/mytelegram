﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputCheckPasswordEmpty" />
///</summary>
[TlObject(0x9880f658)]
public class TInputCheckPasswordEmpty : IInputCheckPasswordSRP,IEmpty
{
    public uint ConstructorId => 0x9880f658;


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