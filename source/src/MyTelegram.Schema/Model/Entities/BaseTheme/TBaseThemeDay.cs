﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/baseThemeDay" />
///</summary>
[TlObject(0xfbd81688)]
public class TBaseThemeDay : IBaseTheme
{
    public uint ConstructorId => 0xfbd81688;


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