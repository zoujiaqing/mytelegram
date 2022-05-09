﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/keyboardButtonRow" />
///</summary>
[TlObject(0x77608b83)]
public class TKeyboardButtonRow : IKeyboardButtonRow
{
    public uint ConstructorId => 0x77608b83;
    public TVector<MyTelegram.Schema.IKeyboardButton> Buttons { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Buttons.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Buttons = br.Deserialize<TVector<MyTelegram.Schema.IKeyboardButton>>();
    }
}