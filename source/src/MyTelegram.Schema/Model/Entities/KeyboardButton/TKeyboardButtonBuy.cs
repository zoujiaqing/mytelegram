﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/keyboardButtonBuy" />
///</summary>
[TlObject(0xafd93fbb)]
public class TKeyboardButtonBuy : IKeyboardButton
{
    public uint ConstructorId => 0xafd93fbb;
    public string Text { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Text);
    }

    public void Deserialize(BinaryReader br)
    {
        Text = br.Deserialize<string>();
    }
}